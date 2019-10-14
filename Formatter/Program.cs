using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Extensions;

namespace PptToPdf
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool isNew;
            Share.distinct = new Mutex(true, Properties.Resources.ProcessDistinctCheckString, out isNew);

            if (isNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ToastForm());
            }
            else
            {
                MessageBox.Show("Already running...", "PPT to PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
