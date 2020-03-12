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
   public  class SqlCarousel:ICarousel
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IQueryable<Carousel> GetCarouselBySuiJi(int top)
        {
            var carousel = (from lunbo in db.Carousel
                          orderby Guid.NewGuid()
                          select lunbo).Take(top);
            return carousel;
        }
    }
}
