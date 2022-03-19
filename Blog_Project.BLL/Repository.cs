using Blog_Project.DAL;
using Blog_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.BLL
{
    public class Repository<T> where T : class
    {
        //private DatabaseContext db = new DatabaseContext(); //Singleton: Her Repository'den nesne oluşturduğum zaman context tekrar oluştumaycak

        private DatabaseContext db;
        private DbSet<T> _objectSet;

        public Repository()
        {
            db = RepositoryBase.CreateContext();
            _objectSet = db.Set<T>();
        }
        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public List<T> List(Expression<Func<T,bool>> where)
        {
            return _objectSet.Where(where).ToList(); // x=> x.Id==3 olanlar || a=> a.CategoryId==2
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int Update(T obj)
        {            
            return Save();
        }

        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public T Find(Expression<Func<T,bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }


        private int Save()
        {
            return db.SaveChanges();
        }
    }
}
