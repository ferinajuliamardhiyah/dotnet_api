using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_api.Controllers {
    [ApiController]
    [Route ("user")]
    public class UserController : ControllerBase {
        private static readonly string[] Usernames = new [] {
            "hahaha",
            "hihihi",
            "huhuhu"
        };

        private static readonly string[] Salts = new [] {
            "E1F53135E559C253",
            "84B03D034B409D4E",
            "E1F53135E559C253"
        };

        private static readonly string[] Profiles = new [] {
            "Premium",
            "Free",
            "Free"
        };

        // private List<User> users = new List<User> () {
        //     new User () {
        //         id = 1, username = "hahaha", password = "123456", salt = "E1F53135E559C253", profile = "Free"
        //     },
        //     new User () {
        //         id = 2, username = "hihihi", password = "123456", salt = "84B03D034B409D4E", profile = "Premium"
        //     }
        // };

        private readonly ILogger<UserController> _logger;

        public UserController (ILogger<UserController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> GetAll () {
            return Enumerable.Range (1, 2).Select (index => new User {
                    id = index,
                    username = Usernames[index - 1],
                    password = "123456",
                    salt = Salts[index - 1],
                    profile = Profiles[index - 1],
                })
                .ToArray ();
        }

        [HttpGet ("{id}")]

        public User GetUser (int id) {
            return new User () {
                id = id,
                    username = Usernames[id - 1],
                    password = "123456",
                    salt = Salts[id - 1],
                    profile = Profiles[id - 1],
            };
        }

        [HttpPost]

        public User AddUser (User user) {
            return user;
        }

        [HttpPut ("{id}")]

        public User EditUser (int id, User user) {
            return user;
        }

        [HttpDelete ("{id}")]

        public string DeleteUser (int id) {
            return "User has been deleted succesfully";
        }
    }
}