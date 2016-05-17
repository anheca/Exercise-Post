using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseTwoPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OnCreated { get; private set; }

        private int _vote;

        // public propertie VOTOS using encapsulation 
        public int Votos
        {
            get { return _vote;}
            private set
            {
                if (value < 0)
                    _vote = 0;
                else
                    _vote = value;
            }

        }

        public Post()
        {
            OnCreated = DateTime.Now;
            Votos = 0;
        }

        public void UpVote()
        {
            Votos++;
        }

        public void DownVote()
        {
            Votos--;
        }
    }
}
