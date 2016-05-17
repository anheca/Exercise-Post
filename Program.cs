using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseTwoPost
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post();
            post.Title = "New Post";
            post.Description = "Fisrt exercise using encapsulation.";


            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            DisplayVotos(post);
            Console.ReadKey();

            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();

            DisplayVotos(post);
            Console.ReadKey();
        }

        private static void DisplayVotos(Post post)
        {
            Console.WriteLine("Title      : {0}", post.Title);
            Console.WriteLine("Description: {0}", post.Description);
            Console.WriteLine("Total Votos: {0}", post.Votos);
        }
    }
}
