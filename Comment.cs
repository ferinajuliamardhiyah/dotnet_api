using System;

namespace dotnet_api
{
    public class Comment
    {
        public int id {get; set;}
        public string content {get; set;}
        public string status => "Approved";
        public string create_time {get; set;}
        public string author {get; set;}
        public string email {get; set;}
        public string url {get; set;}
        public int post_id {get; set;}
        public Post post {get; set;}
    }
}
