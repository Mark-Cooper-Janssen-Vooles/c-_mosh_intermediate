using System;
namespace _15_Challenges
{
    public class Post
    {
        public string Title { get; private set; }
        private string Description;
        private DateTime CreatedAt;
        public int Votes { get; private set; } = 0;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreatedAt = DateTime.Now;
        }

        public void UpVote()
        {
            this.Votes += 1;
        }

        public void DownVote()
        {
            this.Votes -= 1;
        }




    }
}
