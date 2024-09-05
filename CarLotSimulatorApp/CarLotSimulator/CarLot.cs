using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> Lot;
        public static int numberOfCars;

        public CarLot() {
            Lot = new List<Car>();
            numberOfCars = 0;
        }
    }
}
