using CarRentalProject.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject {

    public class CarData {

        public readonly List<Car> cars = new List<Car>();

        public CarData() {
            cars.Add(new Car("Mercedes C220 2013", Resources.MERCEDES, Resources.c220, 12.32));
            cars.Add(new Car("GOLF 6 2012", Resources.VOLKSWAGEN, Resources.golf6, 9.70));
            cars.Add(new Car("BMW M5 2020", Resources.BMW, Resources.m5, 36.45));
            cars.Add(new Car("Mercedes GT63s 2019", Resources.MERCEDES, Resources.gt63s, 42.85));
        }
    }

}
