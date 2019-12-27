using System;
using System.Collections;
using System.Collections.Generic;

namespace _25_BoxingAndUnboxingDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); //1 is a value type, gets boxed to object 
            list.Add("Mark"); //string is a reference so boxing wont happen
            list.Add(DateTime.Now); //datetime is a struct (Value type), so boxing happens here too.

            var number = (int)list[1];
            //the 2nd element is a string. if we do a cast to int we will get 'invalid cast exception'.

            var anotherList = new List<int>();
            //anotherList.Add()
            //requires an int, so we get 'type safety' => every element will be an integer. Thus no boxing will happen, since internally it stores a list of integers.

            var names = new List<string>();
            names.Add()
        }
    }
}
