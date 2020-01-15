using System;

namespace dotnet_api
{
    public class Post
    {
        public int id {get; set;}
        public string title {get; set;}
        public string content {get; set;}
        public string tags {get; set;}
        public string status => "Released";
        public string create_time {get; set;}
        public string update_time {get; set;}
        public int author_id {get; set;}
        public User author {get; set;}
    }
}
