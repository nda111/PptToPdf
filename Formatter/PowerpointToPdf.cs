using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;

namespace PptToPdf
{
    internal static class PowerpointToPdf
    {
        public static event ConversionEventHandler ConversionComplete = null;
        private static void OnConversionCompleted(ConversionEventArgs e)
        {
            ConversionComplete?.Invoke(e);
        }

        private static Application app = new Application();

        private static readonly string[] PowerpointExtensions = new string[]
        {
            ".ppt", ".pptx"
        };

        public static async Task<IEnumerable<bool>> ConvertRange(params string[] paths)
        {
            var result = new bool[paths.Length];
            var compelete = true;

            for (int i = 0; i < paths.Length; i++)
            {
                result[i] = await Convert(paths[i], null);
                compelete &= result[i];
            }

            return result;
        }

        private static async Task<bool> Convert(string pptPath, string pdfPath)
        {
            if (pptPath == null)
                throw new ArgumentNullException("Path is null.");

            return await Task.Run(() =>
            {
                // Checking Extensions
                //
                string ext = Path.GetExtension(pptPath);

                if (!PowerpointExtensions.Contains(ext.ToLower()))
                {
                    throw new ArgumentException("Only ppt, pptx file can opened.");
                }

                // Open Presentation
                //
                var presentation = app.Presentations.Open(pptPath, MsoTriState.msoTrue, MsoTriState.msoFalse, MsoTriState.msoFalse);
                try
                {
                    // Todo
                    //
                    if (pdfPath == null)
                    {
                        pdfPath = Path.ChangeExtension(pptPath, ".pdf");
                    }
                    presentation.SaveAs(pdfPath, PpSaveAsFileType.ppSaveAsPDF, MsoTriState.msoTrue);

                    OnConversionCompleted(new ConversionEventArgs(pptPath, pdfPath, true));
                }
                catch
                {
                    presentation.Close();

                    OnConversionCompleted(new ConversionEventArgs(pptPath, pdfPath, false));
                    return false;
                }

                // Close Presentation
                //
                presentation.Close();
                return true;
            });
        }
    }
}
