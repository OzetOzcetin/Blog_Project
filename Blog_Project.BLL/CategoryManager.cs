using Blog_Project.DAL.EntityFramework;
using Blog_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.BLL
{
    public class CategoryManager
    {
        private Repository<Category> repo_category=new Repository<Category>();

        public List<Category> GetCategories()
        {
            return repo_category.List();
        }
    }
}
