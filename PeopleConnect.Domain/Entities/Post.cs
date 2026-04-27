using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleConnect.Domain.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        public required string PostType { get; set; }
        public required string PostTitle { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? Address { get; set; }
        public string? ImageUrl { get; set; }
    }
}
