using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CustomUser> CustomUser { get; set; }
        public DbSet<UserImage> UserImages { get; set; }

        public DbSet<News> News { get; set; }
        public DbSet<NewsImage> NewsImages { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<NewsSubCategory> NewsSubCategories { get; set; }
        public DbSet<NewsComment> NewsComments { get; set; }
        public DbSet<NewsTag> NewsTags { get; set; }
        public DbSet<TagToNews> TagToNews { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<SavedNews> SavedNews { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
