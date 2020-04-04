using System;

namespace stackoverflow
{
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
