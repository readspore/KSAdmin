using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSAdmin.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public List<PostCategory> PostCategorys { get; set; }

        public Category()
        {
            PostCategorys = new List<PostCategory>();
        }
    }
}
