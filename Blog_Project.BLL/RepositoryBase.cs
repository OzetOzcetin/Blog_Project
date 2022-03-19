using Blog_Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.BLL
{
    public class RepositoryBase
    {
        private static DatabaseContext _db; //static: new yapılmadan direk class adı ile erişilebilir.
        private static object _lockSync = new object();

        protected RepositoryBase() //protected: Sadece kendisinden miras alınan sınıflarca erişilebilir.
        {

        }

        public static DatabaseContext CreateContext()
        {
            if (_db == null)
            {
                //MultiType programlar yazıldığı zaman bir çok parçacık üretilir, o zaman if'in içine birden çok iş parçacığı gelme olasılığı var bunu engellemek için lock kullanılır. Lock birden çok müdahaleye izin vermez ve biri bitince diğerine izin verir.

                lock (_lockSync)
                {
                    if(_db == null)
                    {
                        _db = new DatabaseContext();
                    }
                    
                }

                
            }

            return _db;
        }
    }
}
