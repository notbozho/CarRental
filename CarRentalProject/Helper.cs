using FluentTransitions;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Media.AppBroadcasting;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;
using static ReaLTaiizor.Util.RoundInt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentalProject {
    public class Helper {

        public readonly static string PHONE_REGEX = @"[^\d\s\+\-]";
        public readonly static string NON_DIGIT = @"\D";
        public readonly static string STARTS_WITH_PLUS_OR_DIGIT = @"^[\+\d]";

        public static List<HopeTextBox> getInvalidTextBoxes(
            HopeTextBox firstName, 
            HopeTextBox lastName,
            HopeTextBox EGN,
            HopeTextBox telephone
            ) {

            List<HopeTextBox> returnList = new List<HopeTextBox>(); 

            if (firstName.Text.Length < 2) returnList.Add(firstName);
            if (lastName.Text.Length < 2) returnList.Add(lastName);
            if (EGN.Text.Length != 10) returnList.Add(EGN);
            if (telephone.Text.Length < 6 && !Regex.IsMatch(telephone.Text, STARTS_WITH_PLUS_OR_DIGIT)) returnList.Add(telephone);

            return returnList;
        }

        public static void bounceInvalid(HopeTextBox textBox) {
            Transition
                .With(textBox, nameof(BackColor), Color.IndianRed)
                .With(textBox, nameof(Control.Left), textBox.Left + 25)
                .Bounce(TimeSpan.FromMilliseconds(300));
        }

        public static void printReceipt(string orderDetails) {
            int width = 540;
            int height = 960;

            Color backgroundColor = Color.FromArgb(32, 41, 50);
            Color textColor = Color.FromArgb(205, 88, 136);
            Color borderColor = Color.FromArgb(205, 88, 136);

            int orderNumber = new Random().Next(0, 9999);

            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp)) {
                g.Clear(backgroundColor);
            }

            using (Graphics g = Graphics.FromImage(bmp)) {
                string header = "Order #" + orderNumber.ToString("D4");
                Font font = new Font("Inter", 48, FontStyle.Bold);
                SizeF textSize = g.MeasureString(header, font);
                PointF textLocation = new PointF((width - textSize.Width) / 2, 50);
                g.DrawString(header, font, new SolidBrush(textColor), textLocation);
            }

            using (Graphics g = Graphics.FromImage(bmp)) {
                Font font = new Font("Inter", 28);
                SizeF textSize = g.MeasureString(orderDetails, font);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                PointF textLocation = new PointF((width) / 2, (height) / 2);
                g.DrawString(orderDetails, font, new SolidBrush(textColor), textLocation, stringFormat);
            }

            using (Graphics g = Graphics.FromImage(bmp)) {
                Pen pen = new Pen(borderColor, 5);
                g.DrawRectangle(pen, new Rectangle(0, 0, width - 1, height - 1));
            }


            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, $"car_order_{orderNumber}.png");
            bmp.Save(filePath, ImageFormat.Png);
        }
    }
}
