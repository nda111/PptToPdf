using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms.Extensions
{
    public partial class ImageRadioButton : UserControl
    {
        public event EventHandler CheckedChanged = null;
        protected virtual void OnCheckedChanged(EventArgs e)
        {
            CheckedChanged?.Invoke(this, e);
        }

        #region Browsable properties

        private Image normalBackgroundImage = null;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Image NormalBackgroundImage
        {
            get => normalBackgroundImage;
            set
            {
                if (normalBackgroundImage != value)
                {
                    normalBackgroundImage = value;
                    Invalidate();
                }
            }
        }

        private Image selectedBackgroundImage = null;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Image SelectedBackgroundImage
        {
            get => selectedBackgroundImage;
            set
            {
                if (selectedBackgroundImage != value)
                {
                    selectedBackgroundImage = value;
                    Invalidate();
                }
            }
        }

        private CheckState checkState = CheckState.Unchecked;
        private CheckState CheckState
        {
            get => checkState;
            set
            {
                if (checkState != value)
                {
                    bool bRaiseEvent = checkState == CheckState.Checked || value == CheckState.Checked;

                    checkState = value;

                    if (bRaiseEvent)
                    {
                        OnCheckedChanged(new EventArgs());
                    }

                    Invalidate();
                }
            }
        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public bool Checked
        {
            get => checkState == CheckState.Checked;
            set
            {
                if (Checked != value)
                {
                    if (value)
                    {
                        CheckState = CheckState.Checked;
                    }
                    else
                    {
                        if (Parent == null)
                        {
                            CheckState = CheckState.Unchecked;
                        }
                        else
                        {
                            if (Bounds.Contains(Parent.PointToClient(Cursor.Position)))
                            {
                                CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                CheckState = CheckState.Unchecked;
                            }
                        }
                    }
                }
            }
        }

        private Color themeColor = Color.Empty;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Color ThemeColor
        {
            get => themeColor;
            set
            {
                if (themeColor != value)
                {
                    themeColor = value;
                    Invalidate();
                }
            }
        }

        private DockStyle markupDock = DockStyle.Bottom;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public DockStyle MarkupDock
        {
            get => markupDock;
            set
            {
                if (value != markupDock)
                {
                    switch (value)
                    {
                        case DockStyle.Fill:
                        case DockStyle.None:
                            throw new ArgumentException("Invalid value.");

                        default:
                            markupDock = value;
                            Invalidate();
                            break;
                    }
                }
            }
        }

        private double markupWidth = 0.8;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public double MarkupWidth
        {
            get => markupWidth;
            set
            {
                if (value != markupWidth)
                {
                    if (value < 0 || 1 < value)
                    {
                        throw new ArgumentException("Width must be between 0 and 1.");
                    }

                    markupWidth = value;

                    if (CheckState == CheckState.Checked)
                    {
                        Invalidate();
                    }
                }
            }
        }

        private double markupHeight = 0.1;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public double MarkupHeight
        {
            get => markupHeight;
            set
            {
                if (markupHeight != value)
                {
                    if (value < 0 || 1 < value)
                    {
                        throw new ArgumentException("Height must be between 0 and 1.");
                    }

                    markupHeight = value;

                    if (checkState == CheckState.Checked)
                    {
                        Invalidate();
                    }
                }
            }
        }

        #endregion

        public ImageRadioButton()
        {
            InitializeComponent();
        }

        #region Checkstate by Cursor

        protected override void OnMouseEnter(EventArgs e)
        {
            if (CheckState != CheckState.Checked)
            {
                CheckState = CheckState.Indeterminate;
            }

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (CheckState != CheckState.Checked)
            {
                CheckState = CheckState.Unchecked;
            }

            base.OnMouseLeave(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Parent == null)
                {
                    Checked = !Checked;
                }
                else
                {
                    if (!Checked)
                    {
                        foreach (var control in Parent.Controls)
                        {
                            if (!control.Equals(this))
                            {
                                if (control is ImageRadioButton)
                                {
                                    var other = control as ImageRadioButton;

                                    other.Checked = false;
                                }
                            }
                        }

                        Checked = true;
                    }
                }
            }

            base.OnMouseClick(e);
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            Image stateImage = null;

            switch (checkState)
            {
                case CheckState.Unchecked:
                    stateImage = normalBackgroundImage;
                    break;

                case CheckState.Indeterminate:
                case CheckState.Checked:
                    stateImage = selectedBackgroundImage;
                    break;

                default:
                    break;
            }

            if (stateImage != null)
            {
                switch (BackgroundImageLayout)
                {
                    case ImageLayout.None:
                        e.Graphics.DrawImage(stateImage, Point.Empty);
                        break;

                    case ImageLayout.Stretch:
                        e.Graphics.DrawImage(stateImage,
                            new Rectangle(Point.Empty, Size),
                            new Rectangle(Point.Empty, stateImage.Size),
                            GraphicsUnit.Pixel);
                        break;

                    case ImageLayout.Center:
                        e.Graphics.DrawImage(stateImage, (Width - stateImage.Width) / 2, (Height - stateImage.Height) / 2);
                        break;

                    case ImageLayout.Tile:
                        for (int verOffset = 0; verOffset < Height; verOffset += stateImage.Height)
                        {
                            for (int horOffset = 0; horOffset < Width; horOffset += stateImage.Width)
                            {
                                e.Graphics.DrawImage(stateImage, horOffset, verOffset);
                            }
                        }
                        break;

                    case ImageLayout.Zoom:
                        {
                            var bounds = new Rectangle(Point.Empty, Size);

                            if (stateImage.Width > stateImage.Height)
                            {
                                bounds.Height = bounds.Width * stateImage.Width / stateImage.Height;

                                bounds.Y = (Height - bounds.Height) / 2;
                            }
                            else
                            {
                                bounds.Width = bounds.Height * stateImage.Height / stateImage.Width;
                                bounds.X = (Width - bounds.Width) / 2;
                            }

                            e.Graphics.DrawImage(stateImage, bounds);
                        }
                        break;

                    default:
                        break;
                }
            }

            if (checkState == CheckState.Checked)
            {
                using (var brush = new SolidBrush(ThemeColor))
                {
                    int width = (int)(Width * markupWidth);
                    int height = (int)(Height * markupHeight);
                    switch (markupDock)
                    {
                        case DockStyle.Top:
                            width = Width - width;
                            e.Graphics.FillRectangle(brush, width / 2, 0, Width - width, height);
                            break;

                        case DockStyle.Bottom:
                            width = Width - width;
                            e.Graphics.FillRectangle(brush, width / 2, Height - height, Width - width, height);
                            break;

                        case DockStyle.Left:
                            height = Height - height;
                            e.Graphics.FillRectangle(brush, 0, height / 2, width, Height - height);
                            break;

                        case DockStyle.Right:
                            height = Height - height;
                            e.Graphics.FillRectangle(brush, Width - width, height / 2, width, Height - height);
                            break;

                        default:
                            break;
                    }
                }
            }

            base.OnPaint(e);
        }
    }
}
