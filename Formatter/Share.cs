using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Languages;

namespace PptToPdf
{
    internal static class Share
    {
        internal static event EventHandler<Preferences> PreferencesChanged = null;
        private static void OnPreferencesChanged(Preferences pref)
        {
            PreferencesChanged?.Invoke(null, pref);
        }

        internal static Mutex distinct = null;

        internal const string PreferencePath = "pref.config";

        internal static ToastForm toastForm = null;
        internal static ConfigForm configDialog = null;

        private static Preferences preferences = null;
        public static Preferences Preferences
        {
            get => preferences;
            set
            {
                if (preferences != value)
                {
                    preferences = value;
                    OnPreferencesChanged(preferences);
                }
            }
        }

        public static LanguagePack LanguagePack => LanguagePack.FromLanguage(preferences.Language);

        static Share()
        {
            if (File.Exists(PreferencePath))
            {
                using (var stream = File.Open(PreferencePath, FileMode.Open))
                {
                    preferences = Preferences.Read(stream);
                }
            }
            else
            {
                preferences = Preferences.Default;
                using (var stream = File.Create(PreferencePath))
                {
                    Preferences.Write(stream);
                }
            }
        }
    }
}
