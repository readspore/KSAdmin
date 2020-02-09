using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSAdmin.Areas.Admin.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Format { get; set; }
        public string Path { get; set; }
        public string Creation { get; set; }
        public List<Post> Post { get; set; }
        //public string Caption { get; set; }
    }
}
