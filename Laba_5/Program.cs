using System;

namespace laba_5
{
    abstract public class Shape
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Shape(string name)
        {
            this.Name = name;
        }
        abstract public void Area();
        abstract public void Perimeter();
    }
    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }
        public override void Area()
        {
            Console.WriteLine($"Area = {3.14 * this.Radius * this.Radius}");
        }
        public override void Perimeter()
        {
            Console.WriteLine("Circle doesn't have Perimeter");
        }
        public void Print()
        {
            Console.WriteLine($"Circle name: {Name}, radius = {this.Radius}");
        }
    }
    public class Square : Shape
    {
        private int side;
        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public Square(string name, int side) : base(name)
        {
            this.Side = side;
        }
        public override void Perimeter()
        {
            Console.WriteLine($"Perimeter = {4 * this.Side}");
        }
        public override void Area()
        {
            Console.WriteLine($"Area = {this.Side * this.Side}");
        }
        public void Print()
        {
            Console.WriteLine($"Square name: {Name}, side = {this.Side}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle("my", 2);
            circle1.Print();
            circle1.Area();
            circle1.Perimeter();

            Circle circle2 = new Circle("my2", 4);
            circle2.Print();
            circle2.Area();
            circle2.Perimeter();

            Square square1 = new Square("new", 3);
            square1.Print();
            square1.Area();
            square1.Perimeter();

            Square square2 = new Square("new2", 6);
            square2.Print();
            square2.Area();
            square2.Perimeter();

        }

    }
}