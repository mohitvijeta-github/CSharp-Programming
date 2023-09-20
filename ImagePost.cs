using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    internal class ImagePost : Post
    {
        public string ImageUrl { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendbyusername, string imageUrl, bool isPublic) 
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUserName = sendbyusername;
            this.ImageUrl = imageUrl;
            this.IsPublic = isPublic;   
            this.ImageUrl= imageUrl;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageUrl,this.SendByUserName);
        }
    }
}
