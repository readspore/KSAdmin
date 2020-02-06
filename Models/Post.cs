using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSAdmin.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int PostParent { get; set; }
        public string Creation { get; set; }
        public string Status { get; set; }
        //public List<PostCategory> PostCategorys { get; set; }
        //public Post()
        //{
        //    PostCategorys = new List<PostCategory>();
        //}
    }
}
