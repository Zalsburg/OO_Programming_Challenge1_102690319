using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input.ToLower() != "c") {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("What would you like to create?");
                Console.WriteLine("(a) Square");
                Console.WriteLine("(b) Rectangle");
                Console.WriteLine("(c) Exit");
                Console.Write("Selection: ");

                input = Console.ReadLine().ToLower();

                if (input == "a") {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------");
                    Console.Write("Colour of square: ");
                    string colour = Console.ReadLine().ToLower();
                    Console.Write("Side length of square (whole number): ");
                    int side;

                    while (!int.TryParse(Console.ReadLine(), out side) || side <= 0) {
                        Console.WriteLine("Please input valid number");
                    }

                    Square newSquare = new Square(colour, side);
                    Console.WriteLine("Square created");
                    Console.WriteLine();
                    
                }
                else if (input == "b") {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------");
                    Console.Write("Colour of rectangle: ");
                    string colour = Console.ReadLine().ToLower();
                    Console.Write("Length of rectangle (whole number): ");
                    int side1;

                    while (!int.TryParse(Console.ReadLine(), out side1) || side1 <= 0) {
                        Console.Write("Please input valid number");
                    }

                    Console.WriteLine("Width of rectangle (whole number): ");
                    int side2;

                    while (!int.TryParse(Console.ReadLine(), out side2) || side2 <= 0) {
                        Console.WriteLine("Please input valid number");
                    }

                    Rectangle newRectangle = new Rectangle(colour, side1, side2);
                    Console.WriteLine("Rectangle created");
                    Console.WriteLine();
                    
                }
                else {
                    Console.WriteLine("Please enter 'a', 'b' or 'c'");
                    Console.WriteLine();
                }
       
            }
        }
    }

    public class Shape {
        public string Colour;

        public Shape(string c) {
            Colour = c;
        }
    }

    public class Quadrilateral : Shape {
        public int Side1Length;
        public int Side2Length;
        public int Side3Length;
        public int Side4Length;

        public Quadrilateral(string c, int side1, int side2, int side3, int side4) : base(c) {
            Side1Length = side1;
            Side2Length = side2;
            Side3Length = side3;
            Side4Length = side4;
        }

        public int GetPerimeter() {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }
    }

    public class Square : Quadrilateral {

        public Square(string c, int side) : base(c, side, side, side, side){                         
        }

        public int GetArea() {
            return Side1Length * Side1Length;
        }
    }

    public class Rectangle : Quadrilateral {

        public Rectangle(string c, int side1, int side2) : base(c, side1, side2, side1, side2) {
        }

        public int GetArea() {
            return Side1Length * Side2Length;
        }
    }

    public class Triangle : Shape {
        public float Side1Length;
        public float Side2Length;
        public float Side3Length;

        public Triangle(string c, float side1, float side2, float side3) : base(c) {
            Side1Length = side1;
            Side2Length = side2;
            Side3Length = side3;
        }

        public float GetPerimeter() {
            return Side1Length + Side2Length + Side3Length;
        }
    }

    public class RightAngleTriangle : Triangle {
        public RightAngleTriangle(string c, float side1, float side2) : base(c, side1, side2, side1/*this value needs to be changed*/) {
        }

        public float GetArea() {
            return 0.5f * Side1Length * Side2Length;
        }
    }

    public class EquilateralTriangle : Triangle {
        public EquilateralTriangle(string c, float side) : base(c, side, side, side) {
        }

        public float GetArea() {
            //return (Math.Sqrt(3f) / 4f) * Side1Length * Side1Length;
        }
    }
}
