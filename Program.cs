using SBodyMassIndex;
using System;

namespace ABodyMassIndex
{
    class Program
    {
        public static void Main(string[] args)
        {
            BodyMassIndex person1 = new BodyMassIndex();
            Console.Write("Plese input your weight in kilogram: ");
            person1.Weight = double.Parse(Console.ReadLine());
            Console.Write("Plese input your height in meter: ");
            person1.Height = double.Parse(Console.ReadLine());
            person1.Result();


        }
    }
}
