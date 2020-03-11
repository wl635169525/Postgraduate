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
   public  class CarouselManager
    {
        ICarousel icarousel = DataAccess.CreateCarousel();
        public IQueryable<Carousel> GetCarouselBySuiJi(int top)
        {
            var carousel = icarousel.GetCarouselBySuiJi(top);
            return carousel;
        }
    }
}
