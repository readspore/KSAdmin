using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSAdmin.Areas.Admin.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int? PostParent { get; set; }
        [BindNever]
        public string Creation { get; set; }

        [Display(Name = "Статус записи")]
        public PostStatus? Status { get; set; }
        public List<PostCategory> PostCategorys { get; set; }
        public int MainImageId { get; set; }
        public FileModel MainImage { get; set; }
        public Post()
        {
            PostCategorys = new List<PostCategory>();
        }
    }
    public enum PostStatus
    {
        Опубликовано=1,
        Черновик=2
    }

}
