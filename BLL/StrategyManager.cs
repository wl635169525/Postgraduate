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
   public  class StrategyManager
    {
        IStrategy istrategy = DataAccess.CreateStrategy();
    
        public IQueryable<Strategy> GetStrategybyTop(int top)
        {
            var strategy = istrategy.GetStrategybyTop(top);
            return strategy;
        }
        public IQueryable<Strategy> GetStrategybyTopUp(int top)
        {
            var strategy = istrategy.GetStrategybyTopUp(top);
            return strategy;
        }

        public IEnumerable<Strategy> GetStrategy()
        {
            var strategy = istrategy.GetStrategy();
            return strategy;
        }

        public Strategy GetStrategyById(int? id)
        {
            var strategy = istrategy.GetStrategyById(id);
            return strategy;
        }

        public IEnumerable<Strategy> IEGetStrategyById(int id)
        {
            var strategys = istrategy.IEGetStrategyById(id);
            return strategys;
        }

        public void RemoveStrategy(Strategy strategy)
        {
            istrategy.RemoveStrategy(strategy);
        }

        public void AddStrategy(Strategy strategy)
        {
            istrategy.AddStrategy(strategy);
        }

        public void EditStrategy(Strategy strategy)
        {
            istrategy.EditStrategy(strategy);
        }
    }
}
