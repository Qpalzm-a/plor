using System;
using System.Collections.Generic;

namespace plor7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.type = "Ground";
            car.seats = 4;
            car.speed = 100;
            car.wheels = 4;
            car.ToString();

            Console.WriteLine();

            Plane plane = new Plane();
            Plane plane2 = new Plane();
            plane.type = "Air";
            plane.seats = 120;
            plane.speed = 700;
            plane.engines = 2;

            plane.ToString();

            Transports.Add(plane);
            Transports.Add(plane2);
            Transports.Add(car);
            Console.WriteLine(Transports.GetTransportInfo());
        }
    }


    class Transport
    {
        public string type { get; set; }
        public int speed { get; set; }
        public int seats { get; set; }
        

        public virtual void ToString()
        {
            Console.WriteLine("Type: " + type + "\nSpeed: " + speed + "\nSeats: " + seats);
        }
    }


    class Car : Transport
    {
        public int wheels { get; set; }

        public override void ToString()
        {
            Console.WriteLine("Type: " + type + "\nSpeed: " + speed + "\nSeats: " + seats + "\nWheels: " + wheels);
        }
    }

    class Plane : Transport
    {
        public int engines { get; set; }

        public override void ToString()
        {
            Console.WriteLine("Type: " + type + "\nSpeed: " + speed + "\nSeats: " + seats + "\nEngines: " + engines);
        }
    }

    static class Transports
    {
        public static List<Transport> transports_list { get; } = new List<Transport>();

        public static int cars = 0;
        public static int planes = 0;

        public static void Add(Transport transport)
        {
            transports_list.Add(transport);
            if (transport is Car) cars++;
            if (transport is Plane) planes++;
        }

        public static string GetTransportInfo()
        {
            return $"\nCars: {cars}\nPlanes: {planes}";
        }

    }
}
