using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
   public  interface ICarousel
    {
        IQueryable<Carousel> GetCarouselBySuiJi(int top);
    }
}
