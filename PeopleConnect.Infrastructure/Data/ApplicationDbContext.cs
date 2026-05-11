using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PeopleConnect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleConnect.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext > options) : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    PostId = 1,
                    PostType = "I Want to Give",
                    PostTitle = "Free Food Distribution for Poor Families",
                    Description = "I have arranged cooked meals for 50 families in need. Anyone facing food shortages can contact me for support.",
                    Name = "Ahnaf",
                    Contact= "01712345678",
                    Address = "Mirpur, Dhaka",
                    ImageUrl = "https://images.unsplash.com/photo-1488521787991-ed7bbaae773c",
                },

                new Post
                {
                    PostId = 2,
                    PostType = "I Need Help",
                    PostTitle = "Winter Clothes Needed for Family",
                    Description = "Looking for warm winter clothing for my family of 4. Jackets, sweaters, gloves - anything to help us through the cold season.",
                    Name = "Abrar",
                    Contact = "01732678932",
                    Address = "Farmgate, Dhaka",
                    ImageUrl = "https://unsplash.com/photos/man-holding-his-leather-jacket-P0W27GRvyww",
                },

                new Post
                {
                    PostId = 3,
                    PostType = "I Want to Give",
                    PostTitle = "School Bag and Stationery Donation",
                    Description = "I have school bags, notebooks, and stationery items for students from low-income families.",
                    Name = "Akash",
                    Contact = "01512345678",
                    Address = "Thakugoan, Rangpur",
                    ImageUrl = "https://images.unsplash.com/photo-1503676260728-1c00da094a0b",
                }
                );
        }
    }
}
