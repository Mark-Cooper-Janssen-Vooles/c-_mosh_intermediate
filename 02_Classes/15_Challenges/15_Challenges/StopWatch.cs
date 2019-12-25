using System;
namespace _15_Challenges
{
    public class StopWatch
    {
        public TimeSpan CurrentTime { get; set; }
        public DateTime StartTime;
        public DateTime StopTime;
        public string Name;

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void StartTimeGo()
        {
           this.StartTime = DateTime.Now;
        }

        public void StopTimeGo()
        {
            this.StopTime = DateTime.Now;
            this.CurrentTime = this.StopTime - this.StartTime;

            Console.WriteLine($"Start time was: {this.StartTime}, stop time was: {this.StopTime}");
        }


    }
}


//when startTime is called, DateTime.Now is called and saved to "startTime".

    //when StopTime is called, another DateTime.Now is called and saved to StopTime, and current time can be calculated.