using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    internal class VideoPost : Post
    {
        public string VideoUrl{ get; set;}
        public int Length { get; set; }


        public VideoPost() { }
        public VideoPost( int id, string title, string sendbyusername, string videourl, int lenght, bool ispublic) 
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUserName = sendbyusername;
            this.IsPublic =ispublic;
            this.VideoUrl=videourl;
            this.Length=lenght;

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", this.ID, this.Title, this.VideoUrl, this.Length, this.SendByUserName);
        }

    }
}
