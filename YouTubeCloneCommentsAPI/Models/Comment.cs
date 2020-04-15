using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeCloneCommentsAPI.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string User { get; set; }
        public string Entry { get; set; }
        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public string VideoId { get; set; }
    }
}
