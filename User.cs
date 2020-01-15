using System;

namespace dotnet_api
{
    public class User
    {
        public int id {get; set;}
        public string username {get; set;}
        public string password {get; set;}
        public string salt {get; set;}
        public string email => $"{username}@email.com";
        public string profile {get; set;}
    }
}
