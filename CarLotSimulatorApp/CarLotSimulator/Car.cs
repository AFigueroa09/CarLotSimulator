using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public string Make;
        public string Model;
        public int Year;
        public string EngineNoise;
        public string HonkNoise;
        public bool IsDriveable;

        public Car (string make = "", string model = "", int year = 0, string engineNoise = "", string honkNoise = "", bool isDriveable = false) {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.numberOfCars++;
        }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public void MakeEngineNoise(string engineNoise) { 
            Console.WriteLine($"{this.Make} {this.Model} from {this.Year} has Engine noise level of {engineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{this.Make} {this.Model} from {this.Year} has Honk noise level of {honkNoise}");
        }
    }
}
