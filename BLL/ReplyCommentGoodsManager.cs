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
   public  class ReplyCommentGoodsManager
    {
        IReplyCommentGoods ireplycommentgoods = DataAccess.CreateReplyCommentGoods();
        public IEnumerable<Goods_hf> GetGoodsReplyById(int id)
        {
            var Goods_hf = ireplycommentgoods.GetGoodsReplyById(id);
            return Goods_hf;
        }
        public void InsertGoodReply(ReplyCommentGoods replygoods)
        {
            ireplycommentgoods.InsertGoodReply(replygoods);
        }
    }
}
