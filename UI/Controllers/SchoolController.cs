using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace UI.Controllers
{
    public class SchoolController : Controller
    {
        YanShenWangEntities db = new YanShenWangEntities();
        SchoolManager schoolManager = new SchoolManager();
        public ActionResult SchoolIndex()
        {
            var school1 = schoolManager.GetSchoolBySuiJi(5);
            var school2 = schoolManager.GetSchoolBySuiJi2(5);
            var school3 = schoolManager.GetSchoolBySuiJi3(5);
            var school4 = schoolManager.GetSchoolBySuiJi4(10);
            var chuanmei = schoolManager.GetSchoolBySuiJi5(5);
            var yixue = schoolManager.GetSchoolBySuiJi6(5);
            var shifan = schoolManager.GetSchoolBySuiJi7(5);
            var ligong = schoolManager.GetSchoolBySuiJi8(5);
            var jinrong = schoolManager.GetSchoolBySuiJi9(5);
            Models.SchoolViewModels Vm = new Models.SchoolViewModels();
            Vm.School1 = school1;
            Vm.School2 = school2;
            Vm.School3 = school3;
            Vm.School4 = school4;
            Vm.ChuanMei = chuanmei;
            Vm.JinRong = jinrong;
            Vm.LiGong = ligong;
            Vm.ShiFan = shifan;
            Vm.YiXue = yixue;
            return View(Vm);
        }
        public ActionResult SchoolDetails(int schoolid)
        {
            Session["schoolid"] = schoolid;
            int School_id = Convert.ToInt32(Session["schoolid"]);
            Models.SchoolViewModels Vm = new Models.SchoolViewModels();
            var school = schoolManager.GetSchoolById(School_id);
            if (school == null)
            {
                return HttpNotFound();
            }
            Vm.GetSchoolByID = school;
            return View(Vm);
        }

    }
}