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
   public  class SqlStrategy:IStrategy
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IQueryable<Strategy> GetStrategybyTop(int top)
        {
            var strategy = from gonglue in db.Strategy
                         orderby gonglue.StrategyID /*descending*/
                         select gonglue;
            return strategy.Take(top);
        }
        public IQueryable<Strategy> GetStrategybyTopUp(int top)
        {
            var strategy = from gonglue in db.Strategy
                           orderby gonglue.StrategyID
                           select gonglue;
            return strategy.Take(top);
        }

        public IEnumerable<Strategy> GetStrategy()
        {
            var strategy = db.Strategy.ToList();
            return strategy;
        }

        public Strategy GetStrategyById(int? id)
        {
            Strategy strategy = db.Strategy.Find(id);
            return strategy;
        }

        public IEnumerable<Strategy> IEGetStrategyById(int id)
        {
            var strategy = db.Strategy.Where(c => c.StrategyID == id);
            return strategy;
        }

        public void RemoveStrategy(Strategy strategy)
        {
            db.Strategy.Remove(strategy);
            db.SaveChanges();
        }

        public void AddStrategy(Strategy strategy)
        {
            db.Strategy.Add(strategy);
            db.SaveChanges();
        }

        public void EditStrategy(Strategy strategy)
        {
            db.Entry(strategy).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
