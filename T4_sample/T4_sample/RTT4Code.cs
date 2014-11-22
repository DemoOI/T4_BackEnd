using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_sample
{
    partial class RTT4
    {
        private List<Post> posts;

        public RTT4(List<Post> posts)
        {
            this.posts = posts;
        }
    }

    public class Post
    {
        public string Date;
        public string Author;
        public string Subject;
    }
}
