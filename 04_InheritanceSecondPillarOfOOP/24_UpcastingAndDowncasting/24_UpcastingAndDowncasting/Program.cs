using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _24_UpcastingAndDowncasting
{

    class Program
    {
        static void Main(string[] args)
        {
            //Text textObj = new Text();
            //Shape shapeObj = textObj;

            ////textObj and shapeObj are both references to the same object in memory.

            //// if you type "textObj." you can see all the porperties/methods of the text object, plus all the properties/methods of the shape object.

            //// if you type "shapeObj." you can see all the properties/methods of the shape object ONLY.

            //textObj.Width = 200;
            //shapeObj.Width = 100;

            //Console.WriteLine(textObj.Width); //this will be 100, because both point to the same reference object in memory.


            //--------
            //More on upcasting:


            //StreamReader reader = new StreamReader(new MemoryStream());

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Mark");
            list.Add(new Text());
            //when you type list.Add(), its argument is an object. So you can store an object or any of its derieved classes (anything else!! which makes it not 'type safe'.)

            //array list you can store any kind of object . Mosh says not to use it becase its not a "type safe" kind of list.
            //you can store a different kind of object in every element.

            var anotherList = new List<Shape>();
            //we can store a shape object, or an instance of any of its derived classes ( like text).

            //--------
            //Stuff on downcasting:

            Shape shape = new Text();
            Text text = (Text)shape;
            //text. now allows you to see all the functions on text and shape.

        }
    }
}
