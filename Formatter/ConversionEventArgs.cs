using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PptToPdf
{
    internal delegate void ConversionEventHandler(ConversionEventArgs e);

    internal class ConversionEventArgs : EventArgs
    {
        public string SourceName { get; } = null;
        public string DestinationName { get; } = null;
        public bool Success { get; } = default;

        public ConversionEventArgs(string source, string destination, bool success)
        {
            SourceName = source;
            DestinationName = destination;
            Success = success;
        }
    }
}
