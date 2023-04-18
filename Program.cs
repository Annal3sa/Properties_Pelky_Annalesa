using System;

namespace Properties_Pelky_Annalesa
{
    class Program
    {
        static void Main(string[] args)
        {
            // are these actually effecting my code
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            // I dont understand what these little green texts do
            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            // I dont know what to put here but I have to put them
            Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
