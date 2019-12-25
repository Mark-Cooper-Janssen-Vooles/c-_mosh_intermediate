using System;

namespace _15_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            //challenge 1: 
            //StopWatchApp();


            //challenge 2:
            PostApp();

        }

        static void StopWatchApp()
        {
            var someBoolean = true;
            var stopWatch = new StopWatch();

            while (someBoolean)
            {
                Console.WriteLine("Welcome to the stopwatch app.");
                Console.WriteLine("1 to start");
                Console.WriteLine("2 to stop");
                Console.WriteLine("3 to check time");
                Console.WriteLine("4 to exit program");

                var entry = Console.ReadLine();

                switch (entry)
                {
                    case "1":
                        stopWatch.StartTimeGo();
                        break;
                    case "2":
                        stopWatch.StopTimeGo();
                        break;
                    case "3":
                        Console.WriteLine(stopWatch.CurrentTime);
                        break;
                    case "4":
                        someBoolean = false;
                        break;
                    default:
                        break;
                }
            }
            


        }

        static void PostApp()
        {
            var newPost = new Post("C Sharp", "I am studying C#. Here is a blog post description.");

            Console.WriteLine("Current Votes: " + newPost.Votes);

            newPost.UpVote();
            newPost.UpVote();
            Console.WriteLine("Current Votes: " + newPost.Votes);

            newPost.DownVote();
            Console.WriteLine("Current Votes: " + newPost.Votes);

            Console.WriteLine(newPost.Title); 
        }
    }
}
