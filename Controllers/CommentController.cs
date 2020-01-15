using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_api.Controllers
{
    [ApiController]
    [Route("comment")]
    public class CommentController : ControllerBase
    {
        private static readonly string[] Contentss = new[]
        {
            "Adrenaline rush", "Too cute to be true"
        };

        private static readonly string[] CreateTimes = new[]
        {
            "20191010", "20200101"
        };

        private static readonly string[] Authors = new[]
        {
            "Rama", "Peter Kavinsky"
        };

        private static readonly string[] Emails = new[]
        {
            "ra_ma", "peter.kavinsky"
        };

        private static readonly string[] Urls = new[]
        {
           "lalala",  "xixixi"
        };

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

        private readonly ILogger<CommentController> _logger;

        public CommentController(ILogger<CommentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Comment> GetAll()
        {
            return Enumerable.Range(1, 2).Select(index => new Comment
            {
                id = index,
                content = Contentss[index-1],
                create_time = CreateTimes[index-1],
                author = Authors[index-1],
                email = $"{Emails[index-1]}@email.com",
                url = $"https://{Urls[index-1]}.co.id",
                post_id = index
            })
            .ToArray();
        }

        [HttpGet("{id}")]

        public Comment GetComment(int id)
        {
            return new Comment() {
                id = id,
                content = Contentss[id-1],
                create_time = CreateTimes[id-1],
                author = Authors[id-1],
                email = $"{Emails[id-1]}@email.com",
                url = $"https://{Urls[id-1]}.co.id",
                post_id = id
            };
        }

        [HttpPost]

        public Comment AddComment(Comment comment)
        {
            return comment;
        }

        [HttpPut("{id}")]

        public Comment EditComment(int id, Comment comment)
        {
            return comment;
        }

        [HttpDelete("{id}")]

        public string DeleteComment(int id)
        {
            return "Comment has been deleted succesfully";
        }

        [HttpGet("{id}/post")]

        public Comment GetCommentPost(int id)
        {
            return new Comment() {
                id = id,
                content = Contentss[id-1],
                create_time = CreateTimes[id-1],
                author = Authors[id-1],
                email = $"{Emails[id-1]}@email.com",
                url = $"https://{Urls[id-1]}.co.id",
                post_id = id,
                post = new Post() {
                    id = id,
                    title = Titles[id - 1],
                    content = Contents[id - 1],
                    tags = Tags[id - 1],
                    create_time = CreateTime[id - 1],
                    update_time = UpdateTime[id - 1],
                    author_id = id
                }
            };
        }
    }
}
