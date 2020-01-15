using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_api.Controllers {
    [ApiController]
    [Route ("post")]
    public class PostController : ControllerBase {
        private static readonly string[] Titles = new [] {
            "The Night Comes for Us",
            "To All The Boys I've Loved Before"
        };

        private static readonly string[] Contents = new [] {
            "Fight scenes",
            "Dating scenes"
        };

        private static readonly string[] Tags = new [] {
            "Action",
            "Romantic Comedy"
        };

        private static readonly string[] CreateTime = new [] {
            "20170810",
            "20180405"
        };

        private static readonly string[] UpdateTime = new [] {
            "20191111",
            "20200104"
        };

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

        private readonly ILogger<PostController> _logger;

        public PostController (ILogger<PostController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Post> GetAll () {
            return Enumerable.Range (1, 2).Select (index => new Post {
                    id = index,
                        title = Titles[index - 1],
                        content = Contents[index - 1],
                        tags = Tags[index - 1],
                        create_time = CreateTime[index - 1],
                        update_time = UpdateTime[index - 1],
                        author_id = index
                })
                .ToArray ();
        }

        [HttpGet ("{id}")]

        public Post GetPost (int id) {
            return new Post () {
                id = id,
                    title = Titles[id - 1],
                    content = Contents[id - 1],
                    tags = Tags[id - 1],
                    create_time = CreateTime[id - 1],
                    update_time = UpdateTime[id - 1],
                    author_id = id
            };
        }

        [HttpPost]

        public Post AddPost (Post post) {
            return post;
        }

        [HttpPut ("{id}")]

        public Post EditPost (int id, Post post) {
            return post;
        }

        [HttpDelete ("{id}")]

        public string DeletePost (int id) {
            return "Post has been deleted succesfully";
        }

        [HttpGet ("{id}/user")]

        public Post GetPostUser (int id) {
            return new Post () {
                id = id,
                    title = Titles[id - 1],
                    content = Contents[id - 1],
                    tags = Tags[id - 1],
                    create_time = CreateTime[id - 1],
                    update_time = UpdateTime[id - 1],
                    author_id = id,
                    author = new User () {
                        id = id,
                        username = Usernames[id - 1],
                        password = "123456",
                        salt = Salts[id - 1],
                        profile = Profiles[id - 1],
                        }
            };
        }

    }
}