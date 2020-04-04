using System;

namespace stackoverflow
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        private int UpVote;
        private int DownVote;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.Created = DateTime.Now;
            this.UpVote = 0;
            this.DownVote = 0;
        }
        public Post(string title, string description, DateTime created, int upVote, int downVote) : this(title, description)
        {
            Created = created;
            UpVote = upVote;
            DownVote = downVote;
        }
        public void SetPostUpVote()
        {
            this.UpVote += 1;
        }
        public void SetPostDownVote()
        {
            this.DownVote += 1;
        }
        public int GetPostVotes()
        {
            return this.UpVote - this.DownVote;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var Post1 = new Post("test post 1", "Test post 1 description");
                Post1.SetPostUpVote();
                Post1.SetPostUpVote();
                Post1.SetPostDownVote();

                Console.WriteLine("{0} has total vote {1}", Post1.Title, Post1.GetPostVotes());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
