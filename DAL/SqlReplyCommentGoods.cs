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
   public  class SqlReplyCommentGoods:IReplyCommentGoods
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Goods_hf> GetGoodsReplyById(int id)
        {
            var Goods_hf = db.Goods_hf.Where(a => a.CGoodsID == id);
            return Goods_hf;
        }
        public void InsertGoodReply(ReplyCommentGoods replygoods)
        {
            db.ReplyCommentGoods.Add(replygoods);
            db.SaveChanges();
        }
    }
}
