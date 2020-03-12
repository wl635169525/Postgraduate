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
   public  class SqlGoods:IGoods
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IQueryable<Goods> GetGoodsByTopID(int top)
        {
            var goods = db.Goods
                .OrderBy(x => x.GoodsID)
                .Take(8);
            return goods;

        }
        public Goods GetGoodsById(int? id)
        {
            Goods goods = db.Goods.Find(id);
            return goods;
        }
    }
}

