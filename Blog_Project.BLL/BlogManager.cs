using Blog_Project.DAL.EntityFramework;
using Blog_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.BLL
{
    public class BlogManager
    {
        private Repository<Blog> repo_blog = new Repository<Blog>();

        public List<Blog> GetAllBlog()
        {
            return repo_blog.List();
        }
    }
}
