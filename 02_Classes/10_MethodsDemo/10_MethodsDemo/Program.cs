using System;

namespace _10_MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            
            Console.WriteLine(calculator.Add(1, 2, 4)); //7
            Console.WriteLine(calculator.Add(1, 2, 4, 2)); //9

            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3 })); //6
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40, 60));
                point.Move(null);

                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);


                point.Move(100, 200);

                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occured");
                //Console.WriteLine(ex);
            }
        }
    }
}
