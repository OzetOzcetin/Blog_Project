using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Project.DAL
{
    public class RepositoryBase
    {
        protected static DatabaseContext context; //static: new yapılmadan direk class adı ile erişilebilir.
        private static object _lockSync = new object();

        protected RepositoryBase() //protected: Sadece kendisinden miras alınan sınıflarca erişilebilir.
        {
            CreateContext();
        }

        public static void CreateContext()
        {
            if (context == null)
            {
                //MultiType programlar yazıldığı zaman bir çok parçacık üretilir, o zaman if'in içine birden çok iş parçacığı gelme olasılığı var bunu engellemek için lock kullanılır. Lock birden çok müdahaleye izin vermez ve biri bitince diğerine izin verir.

                lock (_lockSync)
                {
                    if(context == null)
                    {
                        context = new DatabaseContext();
                    }
                    
                }
            }
        }
    }
}
