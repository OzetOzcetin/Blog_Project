﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.Entities
{
    [Table("Likes")]
    public class Liked
    {
        public int Id { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual User LikedUser  { get; set; }
    }
}
