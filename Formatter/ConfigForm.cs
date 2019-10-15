using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Extensions;
using System.Languages;

namespace PptToPdf
{
    public partial class ConfigForm : Form
    {
        private readonly Dictionary<ImageRadioButton, Panel> tabDictionary = null;

        private StartupPositionFlag alertPosition = StartupPositionFlag.DEFAULT;
        private StartupPositionFlag toastPosition = StartupPositionFlag.BOTTOM;

        private LanguagePack SelectedLanguagePack => LanguagePack.FromLanguage((ELanguages)langComboBox.SelectedIndex);

        public ConfigForm()
        {
            InitializeComponent();

            foreach (ELanguages lang in Enum.GetValues(typeof(ELanguages)))
            {
                langComboBox.Items.Add(LanguagePack.FromLanguage(lang).LanguageName);
            }

            tabDictionary = new Dictionary<ImageRadioButton, Panel>
            {
                { genericMenuButton, genericPanel },
                { alertMenuButton, alertPanel },
                { toastMenuButton, toastPanel }
            };

            alertPanel.Visible = toastPanel.Visible = false;
            genericPanel.Dock = alertPanel.Dock = toastPanel.Dock = DockStyle.Fill;

            LoadPreferences(Share.Preferences);
        }

        private void TapMenu_CheckedChanged(object sender, EventArgs e)
        {
            ImageRadioButton menu = sender as ImageRadioButton;
            Panel tab = tabDictionary[menu];

            foreach (var panel in tabDictionary.Values)
            {
                panel.Visible = panel.Equals(tab);
            }
        }

        private void defaultBtn_Click(object sender, EventArgs e)
        {
            var def = Preferences.Default;
            langComboBox.SelectedIndex = (int)def.Language;
            drivesLabel.Text = def.EnabledDriveLabels;
            alertOpacityTrackBar.Value = (int)(def.AlertOpacity * 100);
            toastOpacityTrackBar.Value = (int)(def.ToastOpacity * 100);
            bottomRightUp.Checked = true;
            bottomBtn.Checked = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var newPref = CreatePreferences();

            if (!newPref.Equals(Share.Preferences))
            {
                var result = MessageBox.Show(SelectedLanguagePack.SaveMessage, SelectedLanguagePack.Save, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    SaveSetting(CreatePreferences());
                }
            }
        }

        private void alertPosition_CheckedChanged(object sender, EventArgs e)
        {
            var btn = sender as ImageRadioButton;

            if (btn.Checked)
            {
                var name = btn.Name;

                var result = StartupPositionFlag.NONE;
                bool hor = false;

                switch (name[0])
                {
                    case 't':
                        result |= StartupPositionFlag.TOP;
                        break;

                    case 'm':
                        result |= StartupPositionFlag.MIDDLE;
                        break;

                    case 'b':
                        result |= StartupPositionFlag.BOTTOM;
                        break;
                }

                foreach (var c in name)
                {
                    if ('A' <= c && c <= 'Z')
                    {
                        if (!hor)
                        {
                            switch (c)
                            {
                                case 'L':
                                    result |= StartupPositionFlag.LEFT;
                                    break;

                                case 'C':
                                    result |= StartupPositionFlag.CENTER;
                                    break;

                                case 'R':
                                    result |= StartupPositionFlag.RIGHT;
                                    break;
                            }

                            hor = true;
                        }
                        else
                        {
                            switch (c)
                            {
                                case 'U':
                                    result |= StartupPositionFlag.UPWARD;
                                    break;

                                case 'D':
                                    result |= StartupPositionFlag.DOWNWARD;
                                    break;

                                case 'L':
                                    result |= StartupPositionFlag.LEFTWARD;
                                    break;

                                case 'R':
                                    result |= StartupPositionFlag.RIGHTWARD;
                                    break;
                            }

                            break;
                        }
                    }
                }

                alertPosition = result;
            }
        }

        private void toastPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (topBtn.Checked)
            {
                toastPosition = StartupPositionFlag.TOP;
            }
            else if (middleBtn.Checked)
            {
                toastPosition = StartupPositionFlag.MIDDLE;
            }
            else if (bottomBtn.Checked)
            {
                toastPosition = StartupPositionFlag.BOTTOM;
            }
        }

        private void langComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void driveTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete);

            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);

                if (driveTextBox.Text.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void fontLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fontLinkedLabel.Text = $"{fontDialog.Font.FontFamily.Name}, {GetFontStyleString(fontDialog.Font.Style)}, {fontDialog.Font.Size}pt";
            }
        }

        #region SETTING

        private Preferences CreatePreferences()
        {
            return new Preferences()
            {
                Font = fontDialog.Font,
                EnabledDriveLabels = driveTextBox.Text,
                Language = (ELanguages)langComboBox.SelectedIndex,

                AlertPosition = alertPosition,
                AlertOpacity = alertOpacityTrackBar.Value / 100.0,

                ToastPosition = toastPosition,
                ToastOpacity = toastOpacityTrackBar.Value / 100.0
            };
        }

        private void LoadPreferences(Preferences preferences)
        {
            fontDialog.Font = preferences.Font;
            fontLinkedLabel.Text = $"{fontDialog.Font.FontFamily.Name}, {GetFontStyleString(fontDialog.Font.Style)}, {fontDialog.Font.Size}pt";
            langComboBox.SelectedIndex = (int)preferences.Language;
            driveTextBox.Text = preferences.EnabledDriveLabels;

            switch (preferences.AlertPosition)
            {
                case StartupPositionFlag.TOP | StartupPositionFlag.LEFT | StartupPositionFlag.DOWNWARD:
                    topLeftDown.Checked = true;
                    break;

                case StartupPositionFlag.TOP | StartupPositionFlag.LEFT | StartupPositionFlag.RIGHTWARD:
                    topLeftRight.Checked = true;
                    break;

                case StartupPositionFlag.TOP | StartupPositionFlag.RIGHT | StartupPositionFlag.DOWNWARD:
                    topRightDown.Checked = true;
                    break;

                case StartupPositionFlag.TOP | StartupPositionFlag.RIGHT | StartupPositionFlag.LEFTWARD:
                    topRightLeft.Checked = true;
                    break;

                case StartupPositionFlag.BOTTOM | StartupPositionFlag.LEFT | StartupPositionFlag.UPWARD:
                    bottomLeftUp.Checked = true;
                    break;

                case StartupPositionFlag.BOTTOM | StartupPositionFlag.LEFT | StartupPositionFlag.RIGHTWARD:
                    bottomLeftRight.Checked = true;
                    break;

                case StartupPositionFlag.BOTTOM | StartupPositionFlag.RIGHT | StartupPositionFlag.UPWARD:
                    bottomRightUp.Checked = true;
                    break;

                case StartupPositionFlag.BOTTOM | StartupPositionFlag.RIGHT | StartupPositionFlag.LEFTWARD:
                    bottomRightLeft.Checked = true;
                    break;
            }
            alertOpacityTrackBar.Value = (int)(preferences.AlertOpacity * 100);

            switch (preferences.ToastPosition)
            {
                case StartupPositionFlag.TOP:
                    topBtn.Checked = true;
                    break;

                case StartupPositionFlag.MIDDLE:
                    middleBtn.Checked = true;
                    break;

                case StartupPositionFlag.BOTTOM:
                    bottomBtn.Checked = true;
                    break;
            }
            toastOpacityTrackBar.Value = (int)(preferences.ToastOpacity * 100);

            Text = Share.LanguagePack.Preferences;
            genericLabel.Text = Share.LanguagePack.Generic;
            fontLabel.Text = Share.LanguagePack.Font;
            languageLabel.Text = Share.LanguagePack.Language;
            drivesLabel.Text = Share.LanguagePack.Drives;
            alertLabel.Text = Share.LanguagePack.Alert;
            alertOpacityLabel.Text = $"{Share.LanguagePack.Opacity}: {alertOpacityTrackBar.Value}%";
            toastLabel.Text = Share.LanguagePack.Toast;
            toastOpacityLabel.Text = $"{Share.LanguagePack.Opacity}: {toastOpacityTrackBar.Value}%";
        }

        private void SaveSetting(Preferences pref)
        {
            using (var stream = File.Open(Share.PreferencePath, FileMode.Open))
            {
                pref.Write(stream);
            }

            Share.Preferences = pref;
        }

        #endregion

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;

            var newPref = CreatePreferences();

            if (!newPref.Equals(Share.Preferences))
            {
                var result = MessageBox.Show(SelectedLanguagePack.SaveMessage, SelectedLanguagePack.Save, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveSetting(newPref);
                        Hide();
                        break;

                    case DialogResult.No:
                        Hide();
                        break;

                    case DialogResult.Cancel:
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Hide();
            }
        }

        private void alertOpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            alertOpacityLabel.Text = $"{Share.LanguagePack.Opacity}: {alertOpacityTrackBar.Value}%";
            alertPreviewBox.ImageOpacity = alertOpacityTrackBar.Value / 100.0;
        }

        private void toastOpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            toastOpacityLabel.Text = $"{Share.LanguagePack.Opacity}: {toastOpacityTrackBar.Value}%";
            toastPreviewBox.ImageOpacity = toastOpacityTrackBar.Value / 100.0;
        }

        private void uncheckable_CheckedChanged(object sender, EventArgs e)
        {
            (sender as ImageRadioButton).Checked = false;
        }

        private string GetFontStyleString(FontStyle style)
        {
            var result = new StringBuilder();

            foreach (var s in new FontStyle[] { FontStyle.Bold, FontStyle.Italic, FontStyle.Underline, FontStyle.Strikeout, FontStyle.Strikeout })
            {
                if (style.HasFlag(s))
                {
                    result.Append(s.ToString());
                    result.Append(", ");
                }
            }

            if (result.Length > 0)
            {
                result.Remove(result.Length - 2, 2);
                return result.ToString();
            }
            else
            {
                return "Regular";
            }
        }

        private void ConfigForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                LoadPreferences(CreatePreferences());
            }
        }
    }
}
