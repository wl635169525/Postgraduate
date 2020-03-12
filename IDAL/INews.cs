using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
   public  interface INews
    {
        IQueryable<News> GetNewsbyTop(int top);

        IEnumerable<News> GetNews();

        News GetNewsById(int? id);
    }
}
