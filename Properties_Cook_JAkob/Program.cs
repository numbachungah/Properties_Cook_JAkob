using System;

namespace Properties_Cook_JAkob
{
    class Program
    {
        static void Main(string[] args)
        {
            car car = new car();
            car.Make = "Rolls Royce";
            car.Model = "Ghost";

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            car car2 = new car();
            car2.Make = "Ford";
            car2.Model = "F150";

            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

           


        }
    }
}
