using System;
namespace _10_MethodsDemo
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            //error handling:
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            //this.X = newLocation.X;
            //this.Y = newLocation.Y;

            //can instead write this: isolates bug fixing etc to just one area of the program.
            Move(newLocation.X, newLocation.Y);
        }
    }
}
