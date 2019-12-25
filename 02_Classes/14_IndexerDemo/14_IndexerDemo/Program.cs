using System;
using System.Collections.Generic;

namespace _14_IndexerDemo
{
    public class HttpCookie
    {
        //dictionary is the data type, uses a hash table to store data. Fast to lookup an item by its key (a list of objects looked up by a key, i.e. a string or something).
        //if you have a list of objects to be looked up by an index, then just a list.

        //this dictionary is of type string and string. i.e. the key (first one) and value are both of type string.
        private readonly Dictionary<string, string> _dictionary;
        public 

        public HttpCookie()
        {
            this._dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return this._dictionary[key];  }
            set { this._dictionary[key] = value; }
            //value is a keyword which represents what is on the right side of the assignment operator.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mark";

            Console.WriteLine(cookie["name"]);
        }
    }
}
