using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using UI.Models;
using BLL;

namespace UI.Controllers
{
    public class StrategyController : Controller
    {
        // GET: Strategy
        YanShenWangEntities db = new YanShenWangEntities();
        StrategyManager strategymanager = new StrategyManager();
        public ActionResult Strategy()
        {

            var strategy1 = strategymanager.GetStrategybyTop(3);
            var strategyall = strategymanager.GetStrategy();
            Models.StrategyViewModel Vm = new StrategyViewModel();

            Vm.Strategy1 = strategy1;
            Vm.Strategy2 = strategyall;
            return View(Vm);

        }

        public ActionResult StrategyDetail(int strategyid)
        {

            Session["strategyid"] = strategyid;
            //int StrategyID = Convert.ToInt32(Session["strategyid"]);
            var strategys = strategymanager.GetStrategyById(strategyid);
            if (strategys == null)
            {
                return HttpNotFound();
            }
            return View(strategys);
        }
    }
}