﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    internal class Post
    {
        // Properties 
        private static int currentPostId;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        public Post() 
        
        {
            ID = 0;
            Title = "My First Post ";
            SendByUserName = "Mohit Vijeta";
            IsPublic = true;
        }   

        public Post(int id, string title , string sendbyusername , bool ispublic ) 
        
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUserName = sendbyusername;
            this.IsPublic = ispublic;
        }
        protected int GetNextId()
        {
            return currentPostId++;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title,this.SendByUserName);
        }
    }
}
