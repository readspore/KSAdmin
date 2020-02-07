using KSAdmin.Areas.Admin.Models;
using KSAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSAdmin.Areas.Admin.ViewModels
{
    public class PostCreateViewModel
    {
        public Post newPost { get; set; }
        public Array PostStatusOptions { get; set; }
        public List<Category> Cats { get; set; }
        public List<Post> Posts { get; set; }


    }
}
