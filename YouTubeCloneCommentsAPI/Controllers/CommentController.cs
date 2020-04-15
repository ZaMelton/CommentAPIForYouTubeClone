using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YouTubeCloneCommentsAPI.Data;
using YouTubeCloneCommentsAPI.Models;

namespace YouTubeCloneCommentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {

        private ApplicationContext _context;
        public CommentController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Comment
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            var comments = _context.Comments.ToList();
            return comments;
        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("{VideoId}")]
        public IEnumerable<Comment> Get(string VideoId)
        {
            var videoComments = _context.Comments.Where(c => c.VideoId == VideoId).ToList();
            return videoComments;
        }

        // POST: api/Comment
        [HttpPost]
        public void Post([FromBody] Comment comment)
        {
            Comment newComment = new Comment()
            {
                Entry = comment.Entry,
                User = comment.User,
                VideoId = comment.VideoId,
            };
            _context.Add(newComment);
            _context.SaveChanges();
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Comment comment)
        {
            var commentFromDb = _context.Comments.FirstOrDefault(c => c.CommentId == id);
            commentFromDb.Like = comment.Like;
            commentFromDb.Dislike = comment.Dislike;
            _context.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var comment = _context.Comments.FirstOrDefault(c => c.CommentId == id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }
    }
}
