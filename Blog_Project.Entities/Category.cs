using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.Entities
{
    [Table("Categories")]
    public class Category:EntityBase
    {
        [Required, StringLength(30)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

        public virtual List<Blog> Blogs { get; set; }

        public Category()
        {
            Blogs= new List<Blog>();
        }
    }
}
