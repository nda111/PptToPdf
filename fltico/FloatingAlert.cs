using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms.Extensions
{
    public partial class FloatingAlert : Form
    {
        #region public static Properties

        private static List<FloatingAlert> currentVisible = new List<FloatingAlert>();
        public static FloatingAlert[] CurrentVisible => currentVisible.ToArray();

        #endregion

        #region private static Fields

        private static readonly Image CloseBackground = Properties.Resources.Close;
        private static readonly Image CloseHoverBackground = Properties.Resources.CloseHover;

        private static readonly List<Point> occupiedLocations = new List<Point>();

        #endregion

        #region Events

        public event MouseEventHandler LeftButtonClick = null;
        protected virtual void OnLeftButtonClicked(MouseEventArgs e)
        {
            LeftButtonClick?.Invoke(this, e);
        }

        #endregion

        #region public Properties

        private string fileFullName = null;
        public string FileFullName
        {
            get => fileFullName;
            set
            {
                fileFullName = value;
                FilePath = Path.GetDirectoryName(fileFullName);
                FileName = Path.GetFileName(fileFullName);

                pathLabel.Text = ShortenPath(FilePath);
                nameLabel.Text = ShortenName(FileName);
            }
        }
        public string FilePath { get; private set; } = null;
        public string FileName { get; private set; } = null;

        public bool IsFileExists => File.Exists(fileFullName);

        private double maxOpacity = 1;
        public double MaximumOpacity
        {
            get => maxOpacity;
            set
            {
                if (value != maxOpacity)
                {
                    if (value < 0 || 1 < value)
                    {
                        throw new ArgumentOutOfRangeException("Opacity must be between 0 and 1.");
                    }

                    maxOpacity = value;
                }
            }
        }

        public StartupPositionFlag StartupPosition { get; set; } = StartupPositionFlag.DEFAULT;

        #endregion

        #region private Fields

        private int animationTime = 0;
        private readonly int[] AnimationSteps = { 25, 425, 100 };
        private int TotalTime => AnimationSteps.Sum();

        private bool bCloseCommanded = false;
        private bool bClose = false;

        #endregion

        public FloatingAlert(string filePath)
        {
            InitializeComponent();

            FileFullName = filePath;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (!bCloseCommanded)
            {
                animationTime = AnimationSteps[0] + 1;
            }

            base.OnMouseEnter(e);
        }

        private void titleLabel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    OnLeftButtonClicked(e);
                    break;

                default:
                    break;
            }
        }

        #region Close Button

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = CloseHoverBackground;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = CloseBackground;
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Close();
                    break;

                default:
                    break;
            }
        }

        #endregion

        public new void Close()
        {
            if (!bCloseCommanded)
            {
                bCloseCommanded = true;

                AnimationSteps[AnimationSteps.Length - 1] = 10;
                int closeTime = AnimationSteps.Sum() - AnimationSteps.Last() + 1;

                if (animationTime < closeTime)
                {
                    animationTime = closeTime;
                }
            }

            if (bClose)
            {
                currentVisible.Remove(this);
                occupiedLocations.Remove(Location);

                base.Close();
            }
        }

        public void ShowAlert()
        {
            Point pos = default;
            Size srcSz = Screen.PrimaryScreen.WorkingArea.Size;

            if (occupiedLocations.Count == 0)
            {
                switch (StartupPosition.GetHorizontalFlag())
                {
                    case StartupPositionFlag.LEFT:
                        pos.X = 0;
                        break;

                    case StartupPositionFlag.RIGHT:
                        pos.X = srcSz.Width - Width;
                        break;

                    default:
                        break;
                }

                switch (StartupPosition.GetVerticalFlag())
                {
                    case StartupPositionFlag.TOP:
                        pos.Y = 0;
                        break;

                    case StartupPositionFlag.BOTTOM:
                        pos.Y = srcSz.Height - Height;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                pos = occupiedLocations.Last();

                switch (StartupPosition.GetDirectionFlag())
                {
                    case StartupPositionFlag.UPWARD:
                        pos.Y -= Height;
                        if (pos.Y < 0)
                        {
                            pos.Y = srcSz.Height - Height;
                        }
                        break;

                    case StartupPositionFlag.DOWNWARD:
                        pos.Y += Height;
                        if (pos.Y + Height > srcSz.Height)
                        {
                            pos.Y = 0;
                        }
                        break;

                    case StartupPositionFlag.LEFTWARD:
                        pos.X -= Width;
                        if (pos.X < 0)
                        {
                            pos.X = srcSz.Width - Width;
                        }
                        break;

                    case StartupPositionFlag.RIGHT:
                        pos.X += Width;
                        if (pos.X + Width >= srcSz.Width)
                        {
                            pos.X = 0;
                        }
                        break;

                    default:
                        break;
                }
            }

            Location = pos;
            occupiedLocations.Add(pos);
            currentVisible.Add(this);

            Task.Run(() =>
            {
                Action<double> setOpacity = (opacity) => { Opacity = opacity; };
                Action close = Close;

                try
                {
                    animationTime = 0;

                    Invoke(setOpacity, 0);

                    while (++animationTime <= TotalTime)
                    {
                        double opacity = TimeToOpacity(animationTime, AnimationSteps);
                        Invoke(setOpacity, opacity * maxOpacity);

                        using (var delay = Task.Delay(10))
                            delay.Wait();
                    }

                    bClose = true;
                    Invoke(close);
                }
                catch (InvalidOperationException) { }
            });
        }

        #region private Methods

        private string ShortenPath(string path)
        {
            var parts = new List<KeyValuePair<string, float>>();
            int enableWidth = Width - (pathLabel.Left * 2);
            float pathWidth = 0F;
            float dotWidth = 0F;

            using (var graphics = CreateGraphics())
            {
                dotWidth = graphics.MeasureString("...\\", Font).Width;

                foreach (var pt in path.Split('\\'))
                {
                    var p = pt + '\\';
                    var width = graphics.MeasureString(p, Font).Width;

                    parts.Add(new KeyValuePair<string, float>(p, width));
                    pathWidth += width;
                }
            }

            if (pathWidth > enableWidth)
            {
                pathWidth += dotWidth - parts[parts.Count / 2].Value;

                int start = parts.Count / 2;
                int end = parts.Count / 2;

                while (pathWidth > enableWidth)
                {
                    if (pathWidth > enableWidth)
                    {
                        start--;
                        pathWidth += dotWidth - parts[start].Value;
                    }
                    else break;

                    if (pathWidth > enableWidth)
                    {
                        end++;
                        pathWidth += dotWidth - parts[end].Value;
                    }
                }

                string result = "";
                for (int i = 0; i <= start; i++)
                {
                    result += parts[i].Key;
                }
                result += "...\\";
                for (int i = end; i < parts.Count; i++)
                {
                    result += parts[i].Key;
                }

                return result;
            }
            else
            {
                return path;
            }
        }

        private string ShortenName(string fileName)
        {
            int enableWidth = Width - (nameLabel.Left * 2);

            using (var graphics = CreateGraphics())
            {
                float width = graphics.MeasureString(fileName, Font).Width;

                if (width > enableWidth)
                {
                    var builder = new StringBuilder();
                    float dotWidth = graphics.MeasureString("...", Font).Width;
                    width = 0;

                    for (int i = 0; width + dotWidth < enableWidth; i++)
                    {
                        builder.Append(fileName[i]);

                        width = graphics.MeasureString(builder.ToString(), Font).Width;
                    }
                    builder.Append("...");

                    return builder.ToString();
                }
                else
                {
                    return fileName;
                }
            }
        }

        private double TimeToOpacity(int time, int[] steps)
        {
            int idx = 0;
            int[] step = new int[steps.Length + 1];

            step[0] = 0;
            steps.CopyTo(step, 1);
            for (int i = 1; i < step.Length; i++)
                step[i] += step[i - 1];

            for (int i = 1; i < step.Length; i++)
                if (time <= step[i])
                {
                    idx = i - 1;
                    break;
                }

            switch (idx)
            {
                case 0:
                    return (double)time / (step[idx + 1] - step[idx]);

                case 1:
                    return 1;

                case 2:
                    return 1 - (double)(time - step[idx]) / (step[idx + 1] - step[idx]);

                default:
                    return 0;
            }
        }

        private IEnumerable<IntPtr> GetWindowsFromPid(Process proc)
        {
            var handles = new List<IntPtr>();

            foreach (ProcessThread thread in proc.Threads)
            {
                WindowsApi.EnumThreadWindows(thread.Id,
                    (hWnd, lParam) =>
                    {
                        handles.Add(hWnd);
                        return true;
                    }, IntPtr.Zero);
            }

            return handles;
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

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}
