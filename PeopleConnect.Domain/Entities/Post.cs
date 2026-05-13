using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleConnect.Domain.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        [Required]
        public string? PostType { get; set; }
        [Required]
        public string? PostTitle { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public string? Description { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }
        [Required]
        public string? Contact { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required(ErrorMessage ="ImageUrl is Required")]
        [Display(Name = "Image Url")]
        public string? ImageUrl { get; set; }
    }
}
