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
  public   class SqlCommentGoods:ICommentGoods
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Goods_pl> GetGoodsCommentById(int id)
        {
            var Goods_pl = db.Goods_pl.Where(a => a.GoodsID == id);
            return Goods_pl;

        }

        public void InsertGoodsComment(CommentGoods commentgoods)
        {
            db.CommentGoods.Add(commentgoods);
            db.SaveChanges();
        }
    }
}
