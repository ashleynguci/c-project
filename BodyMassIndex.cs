using System;
namespace SBodyMassIndex
{
    public class BodyMassIndex
    {
        public double Weight
        { get; set; }
        public double Height
        { get; set; }
        public BodyMassIndex()
        {

        }
        public BodyMassIndex(double Weight, double Height)
        {
            this.Weight = Weight;
            this.Height = Height;
        }
        public double CountingBMI(double Weight, double Height)
        {
            double BMI = Weight / (Height * Height);
            return BMI;
        }
        public void Result()
        {
            double newBMI = CountingBMI(this.Weight, this.Height);
            if (newBMI < 16.0)
            {
                Console.WriteLine("Hi, your BMI index is {0:0.00} and you are severe underweight", newBMI);
            }
            else if (newBMI >= 16.0 & newBMI <= 16.99)
            {
                Console.WriteLine("Hi, your BMI index is {0:0.00} and you are underweight",newBMI);
            }
            else if (newBMI >= 17 & newBMI <= 18.49)
            {
                Console.WriteLine("Hi, your BMI index is {0:0.00} and you are mild underweight", newBMI);
            }
            else if (newBMI >= 18.5 & newBMI <= 24.99)
            {
                Console.WriteLine("Hi, your BMI index is {0:0.00} and you are normal", newBMI);
            }
            else if (newBMI >= 25 & newBMI <= 29.99)
            {
                Console.WriteLine("Hi, your BMI index is {0:0.00} and you are mild overweight", newBMI);
            }
            else if (newBMI >= 30.0 & newBMI <= 34.99)
            {
                Console.WriteLine("Hi, your BMI index is {0:0.00} and you are overweight", newBMI);
            }
            else if (newBMI >= 35.0 & newBMI <= 39.99)
            {
                Console.WriteLine("Hi, your BMI index is {0:0.00} and you are severe overweight",newBMI);
            }
            else if (newBMI >= 40.0)
            {
                Console.WriteLine("Hi, your BMI index is {0:0.00} and you are severe obesity", newBMI);
            }
        }
    }
}
