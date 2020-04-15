using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeCloneCommentsAPI.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string User { get; set; }
        public string Entry { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
    }
}
