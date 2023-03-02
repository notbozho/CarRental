using ReaLTaiizor;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject {
    public class IconComboBox : HopeComboBox {

        private ImageList iconList;

        public ImageList IconList {
            get { return iconList; }
            set { iconList = value; }
        }

        public IconComboBox() {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Font = new("Inter", 12F);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);

            if (m.Msg is 0x000F or 0x133) {
                IntPtr hDC = GetWindowDC(m.HWnd);
                if (hDC.ToInt32() == 0) {
                    return;
                }


                Graphics graphics = Graphics.FromHdc(hDC);

                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.Clear(Parent.BackColor);

                GraphicsPath backPath = RoundRectangle.CreateRoundRect(1, 1, Width - 2, Height - 2, 2);
                graphics.FillPath(new SolidBrush(Color.White), backPath);
                graphics.DrawPath(new(Color.FromArgb(145, 49, 117), 2), backPath);

                graphics.FillRectangle(new SolidBrush(Color.White), new RectangleF(1, 1, Width - 2, Height - 2));

                graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(145, 49, 117)), new Point(6, 6));

                graphics.DrawString("6", new Font("Marlett", 12), new SolidBrush(SystemColors.ControlDark), new Rectangle(Width - 22, (Height - 18) / 2, 18, 18));

                _ = ReleaseDC(m.HWnd, hDC);
            }
        }



        protected override void OnDrawItem(DrawItemEventArgs e) {
            if (e.Index < 0) {
                return;
            }

            e.DrawBackground();
            e.DrawFocusRectangle();

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            int textPadding = 5;
            int imageWidth = 0;
            if (IconList != null && IconList.Images.Count > 0) {
                imageWidth = IconList.ImageSize.Width + textPadding;
            }

            Rectangle textRect = new Rectangle(e.Bounds.X + imageWidth, e.Bounds.Y, e.Bounds.Width - imageWidth, e.Bounds.Height);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(200, 200, 200)), e.Bounds);

                if (IconList != null && IconList.Images.Count > 0 && e.Index < IconList.Images.Count) {
                    Image image = IconList.Images[e.Index];

                    e.Graphics.DrawImage(image, e.Bounds.X + textPadding, e.Bounds.Y + ((e.Bounds.Height - image.Height) / 2));
                }

                e.Graphics.DrawString(base.GetItemText(base.Items[e.Index]), Font, new SolidBrush(Color.FromArgb(145, 49, 117)), textRect, HopeStringAlign.Left);
            }
            else {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                Color textColor = Color.FromArgb(145, 49, 117);

                if (IconList != null && IconList.Images.Count > 0 && e.Index < IconList.Images.Count) {
                    Image image = IconList.Images[e.Index];

                    e.Graphics.DrawImage(image, e.Bounds.X + textPadding, e.Bounds.Y + ((e.Bounds.Height - image.Height) / 2));
                }

                e.Graphics.DrawString(base.GetItemText(base.Items[e.Index]), Font, new SolidBrush(textColor), textRect, HopeStringAlign.Left);
            }
            e.Graphics.Dispose();

        }
    }
}
