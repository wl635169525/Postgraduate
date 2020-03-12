using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;
using System.Data.Entity;

namespace DAL
{
   public  class SqlNews:INews
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IQueryable<News> GetNewsbyTop(int top)
        {
            var news = from zixun in db.News
                           orderby zixun.NewsTime descending
                           select zixun;
            return news.Take(top);
        }
        public IEnumerable<News> GetNews()
        {
            var news = db.News.ToList();
            return news;
        }

        public News GetNewsById(int? id)
        {
            News news = db.News.Find(id);
            return news;
        }
    }
}
