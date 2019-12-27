using System;

namespace _29_AbstractClassesAndMembersDEMO
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copied shape into clipboard!");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw(); //it wont print anything since it wasnt specified in the rectangle class, it just runs the empty one in shape.

            //if you make draw in shape an abstract, it makes shape abstract, and forces rectangle to have a draw() method of its own!


            //var shape = new Shape();
            //now cannot instantiate shape! since it is abstract.
        }
    }
}
