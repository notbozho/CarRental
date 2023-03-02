using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject {
    public class Car {

        private string model;
        private Image logo;
        private Image preview;
        private double ratePerDay;

        public Car(string model, Image logo, Image preview, double ratePerDay) {
            Model = model;
            Logo = logo;
            Preview = preview;
            RatePerDay = ratePerDay;
        }

        public string Model { get => model; set => model = value; }
        public Image Logo { get => logo; set => logo = value; }
        public Image Preview { get => preview; set => preview = value; }
        public double RatePerDay { get => ratePerDay; set => ratePerDay = value; }
    }
}
