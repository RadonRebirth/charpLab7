using System;

namespace charpLab7
{
    abstract class Transport
    {
        int speed;
        int capacity;
        int distance;
        public Transport(int speed, int capacity, int distance)
        {
            this.speed = speed;
            this.capacity = capacity;
            this.distance = distance;
        }
        public void speedinf() => Console.WriteLine($"Скорость транспорта {speed}");
        public void capacityinf() => Console.WriteLine($"Скорость транспорта {capacity}");
        public void distanceinf() => Console.WriteLine($"Скорость транспорта {distance}");
    }
    class Car : Transport
    {
        public Car(int speed, int capacity, int distance) : base(speed, capacity, distance) { }
    }
    class Ship : Transport
    {
        public Ship(int speed, int capacity, int distance) : base(speed, capacity, distance) { }
    }
    class Airplane : Transport
    {
        public Airplane(int speed, int capacity, int distance) : base(speed, capacity, distance) { }
    }
    class bibika : Car
    {
        int capacity;
        int distance;
        public bibika(int speed, int capacity, int distance) : base(speed, capacity, distance) { }
        public void print() => Console.WriteLine($"Ламборгини грузоподъёмностью {capacity} может проехать {distance}");
    }
    class lodka : Ship
    {
        int capacity;
        int distance;
        public lodka(int speed, int capacity, int distance) : base(speed, capacity, distance) { }
        public void print() => Console.WriteLine($"лодка грузоподъёмностью {capacity} может проехать {distance}");

    }
    class camoletik : Airplane
    {
        int speed;
        int capacity;
        int distance;
        public camoletik(int speed, int capacity, int distance) : base(speed, capacity, distance) { }
        public void print() => Console.WriteLine($"Самолётик грузоподъёмностью {capacity} может проехать {distance}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            camoletik odin = new camoletik(5, 4, 5);
            bibika dwa = new bibika(15, 2, 1);
            lodka tree = new lodka(7, 6, 3);
            odin.print();
            odin.speedinf();
            dwa.print();
            tree.print();
        }
    }
}