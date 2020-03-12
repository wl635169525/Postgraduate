using BLL;
using Models;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class IndexController : Controller
    {
        //首页绑定
        YanShenWangEntities db = new YanShenWangEntities();
        // GET: Index      
        SchoolManager schoolManager = new SchoolManager();
        CourseManager courseManager = new CourseManager();
        NewsManager newsManager = new NewsManager();
        StrategyManager strategyManager = new StrategyManager();
        CarouselManager carouselManager = new CarouselManager();
        public ActionResult Index()
        {

            var school1 = schoolManager.GetSchoolBySuiJi(4);
            var news1 = newsManager.GetNewsbyTop(6);
            var strategy1 = strategyManager.GetStrategybyTop(4);
            var course1 = courseManager.GetCoursesbyTop(3);
            var carousel1 = carouselManager.GetCarouselBySuiJi(1);
            Models.IndexViewModels Vm = new Models.IndexViewModels();
            Vm.School1 = school1;
            Vm.Course1 = course1;
            Vm.Strategy1 = strategy1;
            Vm.News1 = news1;
            Vm.Carousel1 = carousel1;
            return View(Vm);
        }
    }
}