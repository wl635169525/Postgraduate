using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALFactory;
using IDAL;
using Models;

namespace BLL
{
    public  class NewsManager
    {
        INews inews = DataAccess.CreateNews();
        public IQueryable<News> GetNewsbyTop(int top)
        {
            var news = inews.GetNewsbyTop(top);
            return news;
        }
        public News GetNewsById(int? id)
        {
            var news = inews.GetNewsById(id);
            return news;
        }

        public IEnumerable<News> GetNews()
        {
            var news = inews.GetNews();
            return news;
        }
    }
}
