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
    }
}
