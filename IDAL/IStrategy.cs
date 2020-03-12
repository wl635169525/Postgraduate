using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
   public  interface IStrategy
    {

        IQueryable<Strategy> GetStrategybyTop(int top); //查询TOP

        IQueryable<Strategy> GetStrategybyTopUp(int top); //升序查询TOP

        IEnumerable<Strategy> GetStrategy();

        Strategy GetStrategyById(int? id);

        IEnumerable<Strategy> IEGetStrategyById(int id);

        void RemoveStrategy(Strategy strategy);

        void AddStrategy(Strategy strategy);

        void EditStrategy(Strategy strategy);
    }
}
