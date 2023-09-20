using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post newPost = new Post(1,"Happy BirthDay", "Mohit Vijeta" , true);
            Console.WriteLine(newPost.ToString());

            ImagePost ImagePost1 = new ImagePost("Check out my new post " , "Mohit Vijeta", 
                "http://mohitvijeta.com", true);
            Console.WriteLine(ImagePost1.ToString());

            VideoPost videopost1= new VideoPost(1,"Check out my video", "Mohit Vijeta", "http://mohitvijeta.com", 2,true);
            Console.WriteLine(videopost1.ToString());
            Console.Read();
        }
    }
}
