using System;

namespace practice
{
    class Car
    {
        private string Brand;
        private string Model;
        private int Mileage;
        public Car(string brand, string model, int mileage)
        {
            Brand = brand;
            Model = model;
            Mileage = mileage;
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
        public void Drive()
        {
            Console.WriteLine("Driving!");
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {this.Brand}, Model: {this.Model}, Mileage: {this.Mileage}.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mercedes", "xxx", 25);
            car.StartEngine();
            car.Drive();
            car.ShowDetails();
        }
    }
}