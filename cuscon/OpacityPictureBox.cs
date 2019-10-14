using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms.Extensions
{
    public partial class OpacityPictureBox : UserControl
    {
        private Image image = null;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public Image Image
        {
            get => image;
            set
            {
                if (value != image)
                {
                    image = value;
                    Invalidate();
                }
            }
        }

        private ColorMatrix colorMatrix = new ColorMatrix();
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public double ImageOpacity
        {
            get => colorMatrix.Matrix33;
            set
            {
                if (value != colorMatrix.Matrix33)
                {
                    if (value < 0 || 1 < value)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    colorMatrix.Matrix33 = (float)value;
                    Invalidate();
                }
            }
        }

        private ImageLayout imageLayout = ImageLayout.Tile;
        public ImageLayout ImageLayout
        {
            get => imageLayout;
            set
            {
                if (value != ImageLayout)
                {
                    imageLayout = value;

                    Invalidate();
                }
            }
        }


        public OpacityPictureBox()
        {
            InitializeComponent();

            colorMatrix.Matrix33 = 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (image != null)
            {
                var dst = new Rectangle();

                switch (imageLayout)
                {
                    case ImageLayout.None:
                    case ImageLayout.Zoom:
                        dst.Size = image.Size;
                        break;

                    case ImageLayout.Stretch:
                        dst.Size = Size;
                        break;

                    case ImageLayout.Center:
                        dst.Location = new Point((Width - image.Width) / 2, (Height - image.Height) / 2);
                        dst.Size = image.Size;
                        break;

                    default:
                        break;
                }

                using (var attr = new ImageAttributes())
                {
                    attr.SetColorMatrix(colorMatrix);
                    if (imageLayout == ImageLayout.Tile)
                    {
                        for (dst.Y = 0; dst.Y < Height; dst.Y++)
                        {
                            for (dst.X = 0; dst.X < Width; dst.X++)
                            {
                                e.Graphics.DrawImage(image, dst, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attr);
                            }
                        }
                    }
                    else
                    {
                        e.Graphics.DrawImage(image, dst, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attr);
                    }
                }
            }

            base.OnPaint(e);
        }
    }
}
