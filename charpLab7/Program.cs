using System;

namespace charpLab7
{
    abstract class Transport
    {
        public abstract int speed { get; set; }
        public abstract int capacity { get; set; }
        public abstract int distance { get; set; }
        public void speedinf() => Console.WriteLine($"Скорость транспорта {speed}");
        public void capacityinf() => Console.WriteLine($"Скорость транспорта {capacity}");
        public void distanceinf() => Console.WriteLine($"Скорость транспорта {distance}");
    }
    class Car : Transport
    {
        public override int speed { get; set; }
        public override int capacity { get; set; }
        public override int distance { get; set; }
    }
    class Ship : Transport
    {
        public override int speed { get; set; }
        public override int capacity { get; set; }
        public override int distance { get; set; }
    }
    class Airplane : Transport
    {
        public override int speed { get; set; }
        public override int capacity { get; set; }
        public override int distance { get; set; }
    }
    class bibika : Car
    {
        public bibika(int speed, int capacity, int distance){
            this.speed = speed;
            this.capacity = capacity;
            this.distance = distance;
        }
        public void print() => Console.WriteLine($"Ламборгини грузоподъёмностью {capacity} может проехать {distance}");
    }
    class lodka : Ship
    {
        public lodka(int speed, int capacity, int distance){
            this.speed = speed;
            this.capacity = capacity;
            this.distance = distance;
        }
        public void print() => Console.WriteLine($"Лодка грузоподъёмностью {capacity} может проехать {distance}");

    }
    class camoletik : Airplane
    {
        public camoletik(int speed, int capacity, int distance){
            this.speed = speed;
            this.capacity = capacity;
            this.distance = distance;
        }
        public void print() => Console.WriteLine($"Самолётик грузоподъёмностью {capacity} может проехать {distance}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            camoletik odin = new camoletik(5, 15, 200);
            bibika dwa = new bibika(15, 2, 100);
            lodka tree = new lodka(7, 6, 30);
            odin.print();
            odin.speedinf();
            dwa.print();
            tree.print();
        }
    }
}
