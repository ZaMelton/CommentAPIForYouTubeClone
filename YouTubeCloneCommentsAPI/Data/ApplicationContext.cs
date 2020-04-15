using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouTubeCloneCommentsAPI.Models;

namespace YouTubeCloneCommentsAPI.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Comment> Comments { get; set; }
    }
}
