using FluentTransitions;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Media.AppBroadcasting;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;

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

    }
}
