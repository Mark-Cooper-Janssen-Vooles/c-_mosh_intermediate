using System;
namespace _10_MethodsDemo
{
    public class Calculator
    {
        public Calculator()
        {
        }
        public int Add(params int[] numbers)
        {
            //inside here numbers is an integer array. we want to add the array up and return the value

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
