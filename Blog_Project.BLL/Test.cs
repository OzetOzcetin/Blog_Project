using Blog_Project.DAL;
using Blog_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.BLL
{
    public class Test
    {
        private Repository<Category> repo_category = new Repository<Category>();
        private Repository<User> repo_user = new Repository<User>();
        private Repository<Comment> repo_comment = new Repository<Comment>();
        private Repository<Blog> repo_blog = new Repository<Blog>();
        public Test()
        {
            List<Category> categories = repo_category.List(); ;
        }

        public void InsertTest()
        {
            int result = repo_user.Insert(new User()
            {
                Name = "aaa",
                Surname = "bbb",
                Email = "aaa@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "aabb",
                Password = "123",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = "aabb"
            });
        }
        public void UpdateTest()
        {
            User user = repo_user.Find(x => x.Username == "aabb");

            if (user != null)
            {
                user.Username = "xxx";
                int result = repo_user.Update(user);
            }
        }
        public void DeleteTest()
        {
            User user = repo_user.Find(x => x.Username == "xxx");

            if (user != null)
            {
                int result = repo_user.Delete(user);
            }
        }

        public void CommentTest()
        {
            User user = repo_user.Find(x=> x.Id == 1);
            Blog blog = repo_blog.Find(x => x.Id == 3);

            Comment comment = new Comment()
            {
                Text = "Bu bir test'dir.",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = "altanemre",
                Blog = blog,
                Owner = user
            };

            repo_comment.Insert(comment);
        }
    }
}
