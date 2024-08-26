using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            CarLot carLot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            Car subaru = new Car("Subaru", "Impreza", 2002, "Loud", "Low", false);
            carLot.Lot.Add(subaru);

            Car toyota = new Car() { Make = "Toyota", Model = "Camry", Year = 2002, EngineNoise = "Low", HonkNoise = "Low", IsDriveable = true };
            carLot.Lot.Add(toyota);

            //Set the properties for each of the cars
            Car porshe = new Car();
            porshe.Make = "Porshe";
            porshe.Model = "911 Turbo";
            porshe.Year = 2000;
            porshe.IsDriveable = false;
            porshe.EngineNoise = "Loud";
            porshe.HonkNoise = "Average";
            carLot.Lot.Add(porshe);

            //Call each of the methods for each car
            porshe.MakeEngineNoise(porshe.EngineNoise);
            porshe.MakeHonkNoise(porshe.HonkNoise);

            subaru.MakeEngineNoise(subaru.EngineNoise);
            subaru.MakeHonkNoise(subaru.HonkNoise);

            toyota.MakeEngineNoise(subaru.EngineNoise);
            toyota.MakeHonkNoise(subaru.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // DONE

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("Available cars in our Lot");
            foreach (Car car in carLot.Lot)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
        }
    }
}
