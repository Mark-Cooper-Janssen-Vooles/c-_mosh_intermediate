using System;
using System.Collections;

namespace _26_CHALLENGE
{
    public class Stack
    {
        public ArrayList theStack { get; private set; } = new ArrayList();

        public void Push(object obj)
        {
            object anObject = obj as Object;
            Console.WriteLine(anObject);

            if (anObject != null)
            {
                this.theStack.Add(anObject);
                Console.WriteLine("Added obj to the stack");
            } else
            {
                throw new InvalidOperationException("Cannot add null object to the list");
            }
        }

        public object Pop()
        {
            if(theStack.Count > 0)
            {
                var theObj = this.theStack[theStack.Count - 1];
                this.theStack.RemoveAt(theStack.Count - 1);
                Console.WriteLine("The last item from the stack was removed");
                return theObj;
            } else
            {
                Console.WriteLine("theStack is already empty");
                //return null;
                throw new InvalidOperationException("Cannot remove object from an empty list");
            }
        }

        void Clear()
        {
            this.theStack = new ArrayList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
