using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Extensions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Languages;

namespace PptToPdf
{
    [Serializable]
    internal class Preferences
    {
        private string fontName = "Arial";
        private FontStyle fontStyle = FontStyle.Regular;
        private float ptSize = 10;
        public Font Font
        {
            get => new Font(fontName, ptSize, fontStyle, GraphicsUnit.Point);
            set
            {
                fontName = value.FontFamily.Name;
                fontStyle = value.Style;
                ptSize = value.SizeInPoints;
            }
        }
        public string EnabledDriveLabels { get; set; } = "CD";
        public ELanguages Language { get; set; } = ELanguages.English_US;

        public StartupPositionFlag AlertPosition { get; set; } = StartupPositionFlag.DEFAULT;
        public double AlertOpacity { get; set; } = 1;

        public StartupPositionFlag ToastPosition { get; set; } = StartupPositionFlag.BOTTOM;
        public double ToastOpacity { get; set; } = 0.7;

        public Preferences()
        {
        }

        public Preferences(Font font, string driveLabels, ELanguages language, StartupPositionFlag alertPosition, double alertOpacity, StartupPositionFlag toastPosition, double toastOpacity)
        {
            Font = font;
            EnabledDriveLabels = driveLabels;
            Language = language;

            AlertPosition = alertPosition;
            AlertOpacity = alertOpacity;

            ToastPosition = toastPosition;
            ToastOpacity = toastOpacity;
        }

        public static Preferences Default => new Preferences();

        public void Write(Stream stream)
        {
            new BinaryFormatter().Serialize(stream, this);
        }

        public static Preferences Read(Stream stream)
        {
            return new BinaryFormatter().Deserialize(stream) as Preferences;
        }

        public override bool Equals(object obj)
        {
            if (obj is Preferences)
            {
                var other = obj as Preferences;

                return
                    fontName == other.fontName &&
                    fontStyle == other.fontStyle &&
                    ptSize == other.ptSize &&
                    EnabledDriveLabels == other.EnabledDriveLabels &&
                    Language == other.Language &&
                    AlertPosition == other.AlertPosition &&
                    AlertOpacity == other.AlertOpacity &&
                    ToastPosition == other.ToastPosition &&
                    ToastOpacity == other.ToastOpacity;
            }

            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = 1499523268;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(fontName);
            hashCode = hashCode * -1521134295 + fontStyle.GetHashCode();
            hashCode = hashCode * -1521134295 + ptSize.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Font>.Default.GetHashCode(Font);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EnabledDriveLabels);
            hashCode = hashCode * -1521134295 + Language.GetHashCode();
            hashCode = hashCode * -1521134295 + AlertPosition.GetHashCode();
            hashCode = hashCode * -1521134295 + AlertOpacity.GetHashCode();
            hashCode = hashCode * -1521134295 + ToastPosition.GetHashCode();
            hashCode = hashCode * -1521134295 + ToastOpacity.GetHashCode();
            return hashCode;
        }
    }
}
