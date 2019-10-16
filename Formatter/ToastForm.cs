using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Extensions;

namespace PptToPdf
{
    public partial class ToastForm : Form
    {
        #region private static Fields

        private static readonly Image RoundImage = Properties.Resources.Round;

        private static readonly string[] PowerpointExtensions = { ".ppt", ".pptx" };

        private static readonly Rectangle PrimaryScreen = default;

        private static Dictionary<StartupPositionFlag, double> positionMap = new Dictionary<StartupPositionFlag, double>
        {
            { StartupPositionFlag.TOP, 0.1 },
            { StartupPositionFlag.MIDDLE, 0.5 },
            { StartupPositionFlag.BOTTOM, 0.9 },
        };

        static ToastForm()
        {
            PrimaryScreen = Screen.PrimaryScreen.WorkingArea;
        }

        #endregion

        #region private Fields

        private Brush backgroundBrush = null;
        private string[] popupLines = null;
        private int toastLineGap = 2;
        private int toastMinPadding = 10;

        private const int RoundPixel = 30;
        private bool isShown = false;
        private int animationTime = 0;
        private int TotalTime => AnimationSteps.Sum();

        private readonly int[] AnimationSteps = { 25, 300, 25 };

        private bool bHideCommanded = false;
        private bool bHide = false;

        private Dictionary<char, FileSystemWatcher> watchers = new Dictionary<char, FileSystemWatcher>();

        #endregion

        public ToastForm()
        {
            InitializeComponent();

            PowerpointToPdf.ConversionComplete += PowerpointToPdf_ConversionComplete;

            foreach (var drive in DriveInfo.GetDrives())
            {
                AddDrive(drive);
            }

            Share.configDialog = new ConfigForm();

            Share.PreferencesChanged += Share_PreferencesChanged;

            Share_PreferencesChanged(this, Share.Preferences);

            ShowToast(Share.LanguagePack.Startup);
        }

        private void Share_PreferencesChanged(object sender, Preferences e)
        {
            // File System Watcher
            foreach (var watcher in watchers.Values)
            {
                watcher.EnableRaisingEvents = Share.Preferences.EnabledDriveLabels.Contains(watcher.Path[0]);
            }

            // Language
            preferencesToolStripMenuItem.Text = Share.LanguagePack.Preferences;
            quitToolStripMenuItem.Text = Share.LanguagePack.Quit;
            restartToolStripMenuItem.Text = Share.LanguagePack.Restart;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            backgroundBrush = new SolidBrush((RoundImage as Bitmap).GetPixel(RoundImage.Width / 2, RoundImage.Height / 2));

            Action hide = () => { Opacity = 0; };
            Task.Run(() => Invoke(hide));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (popupLines != null)
            {
                int diameter = RoundPixel <= Math.Min(Width, Height) / 2 ? RoundPixel : Math.Min(Width, Height) / 2;
                using (var round = new Bitmap(diameter, diameter))
                {
                    using (var graphics = Graphics.FromImage(round))
                    {
                        graphics.DrawImage(RoundImage,
                            new Rectangle(Point.Empty, round.Size),
                            new Rectangle(Point.Empty, RoundImage.Size),
                            GraphicsUnit.Pixel);
                    }

                    e.Graphics.DrawImage(round, 0, 0);
                    e.Graphics.DrawImage(round, Width - round.Height, 0);
                    e.Graphics.DrawImage(round, 0, Height - round.Width);
                    e.Graphics.DrawImage(round, Width - round.Height, Height - round.Width);
                }
                e.Graphics.FillRectangle(backgroundBrush, diameter / 2, 0, Width - diameter, Height);
                e.Graphics.FillRectangle(backgroundBrush, 0, diameter / 2, Width, Height - diameter);

                float offsetY = diameter / (popupLines.Length == 1 ? 2 : 4);
                foreach (var msgLine in popupLines)
                {
                    var area = new RectangleF();

                    area.Size = e.Graphics.MeasureString(msgLine, Font);
                    area.Location = new PointF((Width - area.Width) / 2, offsetY);

                    e.Graphics.DrawString(msgLine, Font, Brushes.White, area);

                    offsetY += area.Height + toastLineGap;
                }
            }

            base.OnPaint(e);
        }

        public new void Hide()
        {
            if (!bHideCommanded)
            {
                bHideCommanded = true;

                AnimationSteps[AnimationSteps.Length - 1] = 10;
                int closeTime = AnimationSteps.Sum() - AnimationSteps.Last() + 1;

                if (animationTime < closeTime)
                {
                    animationTime = closeTime;
                }
            }

            if (bHide)
            {
                Opacity = 0;
            }
        }

        private void ShowToast(string text)
        {
            if (text != null)
            {
                if (popupLines != null)
                {
                    popupLines = text.Split('\n');
                    Invalidate();
                }
                else
                {
                    popupLines = text.Split('\n');
                }

                int diameter = RoundPixel <= Math.Min(Width, Height) / 2 ? RoundPixel : Math.Min(Width, Height) / 2;
                if (diameter < toastMinPadding)
                {
                    diameter = toastMinPadding;
                }
                float maxWidth = 0;
                float totalHeight = diameter;
                using (var graphics = CreateGraphics())
                {
                    foreach (var line in popupLines)
                    {
                        SizeF lineSize = graphics.MeasureString(line, Font);

                        if (lineSize.Width > maxWidth)
                        {
                            maxWidth = lineSize.Width;
                        }
                        totalHeight += lineSize.Height + toastLineGap;
                    }

                }
                Size = new Size((int)maxWidth + diameter * 5, (int)totalHeight - toastLineGap);
                Left = (PrimaryScreen.Width - Width) / 2;
                Top = (int)((PrimaryScreen.Height - Height) * positionMap[Share.Preferences.ToastPosition]);

                if (isShown)
                {
                    animationTime = 0;
                }
                else
                {
                    Task.Run(() =>
                    {
                        Action<double> setOpacity = (opacity) => { Opacity = opacity; };

                        isShown = true;

                        animationTime = 0;
                        AnimationSteps[AnimationSteps.Length - 1] = 25;
                        bHideCommanded = bHide = false;

                        try
                        {
                            Invoke(setOpacity, 0);

                            while (++animationTime <= TotalTime)
                            {
                                double opacity = TimeToOpacity(animationTime, AnimationSteps);
                                Invoke(setOpacity, opacity);

                                using (var delay = Task.Delay(10))
                                    delay.Wait();
                            }

                            bHide = true;

                            popupLines = null;

                            isShown = false;

                            Action hide = () => { Opacity = 0; };
                            Task.Run(() => Invoke(hide));
                        }
                        catch (ObjectDisposedException) { }
                    });
                }
            }
        }

        private void PowerpointToPdf_ConversionComplete(ConversionEventArgs e)
        {
            if (e.Success)
            {
                Invoke((Action<string>)ShowToast, $"{Share.LanguagePack.ConversionComplete}: {Path.GetFileName(e.SourceName)}");
            }
            else
            {
                Invoke((Action<string>)ShowToast, $"{Share.LanguagePack.ConversionFailed}: {Path.GetFileName(e.SourceName)}");
            }
        }

        private void CoreForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Powerpoint|*.ppt;*.pptx";
                openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                openDialog.Multiselect = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
#pragma warning disable CS4014 // 이 호출을 대기하지 않으므로 호출이 완료되기 전에 현재 메서드가 계속 실행됩니다.
                    PowerpointToPdf.ConvertRange(openDialog.FileNames);
#pragma warning restore CS4014 // 이 호출을 대기하지 않으므로 호출이 완료되기 전에 현재 메서드가 계속 실행됩니다.
                }
            }
        }

        #region Tool Strip Menu Item

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Share.LanguagePack.RestartMessage, Share.LanguagePack.Restart, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Share.distinct.Dispose();

                Application.Restart();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Share.LanguagePack.QuitMessage, Share.LanguagePack.Quit, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Share.configDialog.Show();
        }

        #endregion

        private double TimeToOpacity(int time, int[] steps)
        {
            int idx = 0;
            int[] step = new int[steps.Length + 1];

            step[0] = 0;
            steps.CopyTo(step, 1);
            for (int i = 1; i < step.Length; i++)
            {
                step[i] += step[i - 1];
            }

            for (int i = 1; i < step.Length; i++)
            {
                if (time <= step[i])
                {
                    idx = i - 1;
                    break;
                }
            }

            double result;
            switch (idx)
            {
                case 0:
                    result = (double)time / (step[idx + 1] - step[idx]);
                    break;

                case 1:
                    result = 1;
                    break;

                case 2:
                    result = 1 - (double)(time - step[idx]) / (step[idx + 1] - step[idx]);
                    break;

                default:
                    return 0;
            }

            return result * Share.Preferences.ToastOpacity;
        }

        #region File system watcher

        private void AddDrive(DriveInfo drive)
        {
            var watcher = new FileSystemWatcher(drive.Name)
            {
                IncludeSubdirectories = true,
                EnableRaisingEvents = Share.Preferences.EnabledDriveLabels.Contains(drive.Name[0]),
            };

            watcher.Created += Watcher_PptDetected;
            watcher.Renamed += Watcher_PptDetected;

            watchers.Add(drive.Name[0], watcher);
        }

        private void Watcher_PptDetected(object sender, FileSystemEventArgs e)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(e.FullPath);

                if (!attr.HasFlag(FileAttributes.Temporary) && !Path.GetFileName(e.FullPath).StartsWith("~$"))
                {
                    if (PowerpointExtensions.Contains(Path.GetExtension(e.FullPath).ToLower()))
                    {
                        Invoke((Action<string>)CreateAlert, e.FullPath);
                    }
                }
            }
            catch (FileNotFoundException) { }
            catch (DirectoryNotFoundException) { }
            catch (UnauthorizedAccessException) { }
        }

        private void Alert_LeftButtonClick(object sender, MouseEventArgs e)
        {
            var form = sender as FloatingAlert;

            if (File.Exists(form.FileFullName))
            {
#pragma warning disable CS4014 // 이 호출을 대기하지 않으므로 호출이 완료되기 전에 현재 메서드가 계속 실행됩니다.
                PowerpointToPdf.ConvertRange(form.FileFullName);
#pragma warning restore CS4014 // 이 호출을 대기하지 않으므로 호출이 완료되기 전에 현재 메서드가 계속 실행됩니다.
            }

            form.Close();
        }

        private void Alert_FormClosed(object sender, FormClosedEventArgs e)
        {
            (sender as FloatingAlert).Dispose();
            GC.Collect(0, GCCollectionMode.Forced);
        }

        private void CreateAlert(string path)
        {
            var alert = new FloatingAlert(path);

            alert.MaximumOpacity = Share.Preferences.AlertOpacity;
            alert.StartupPosition = Share.Preferences.AlertPosition;

            alert.LeftButtonClick += Alert_LeftButtonClick;
            alert.FormClosed += Alert_FormClosed;

            alert.Show();
            alert.ShowAlert();
        }

        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ExStyle |= 0x80;

                return param;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case 0x219: // WM_DEVICECHANGE
                    if (m.LParam != IntPtr.Zero)
                    {
                        var drives = from drive in DriveInfo.GetDrives() where !watchers.Keys.Contains(drive.Name[0]) select drive;

                        if (drives.Count() == 1)
                        {
                            DriveInfo drive = drives.First();

                            AddDrive(drive);
                            ShowToast($"{drive.Name[0]}: {Share.LanguagePack.DriveDetected}");
                        }
                        else
                        {
                            var currentLabels = from drive in DriveInfo.GetDrives() select drive.Name[0];

                            foreach (var label in watchers.Keys.ToArray())
                            {
                                if (!currentLabels.Contains(label))
                                {
                                    watchers[label].Dispose();
                                    watchers.Remove(label);
                                    ShowToast($"{label}: {Share.LanguagePack.DriveRemoved}");
                                }
                            }
                        }
                    }
                    break;

                case 0x011: // WM_QUERYENDSESSION
                    Application.Exit();
                    break;

                default:
                    break;
            }
        }

        #region ALERT/TOAST TEST

#if DEBUG

        private void TESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAlert(@"C:\Users\nda11\Desktop\DB00.pptx");
        }

        private int testToastCnt = 0;
        private void tESTToastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowToast(Font.ToString());
        }

#endif

        #endregion
    }
}
