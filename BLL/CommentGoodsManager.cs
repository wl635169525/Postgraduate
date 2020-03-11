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
   public  class CommentGoodsManager
    {
        ICommentGoods icommentgoods = DataAccess.CreateCommentGoods();
        public IEnumerable<Goods_pl> GetGoodsCommentById(int id)
        {
            var Goods_pl = icommentgoods.GetGoodsCommentById(id);
            return Goods_pl;
        }
        public void InsertGoodsComment(CommentGoods commentgoods)
        {
            icommentgoods.InsertGoodsComment(commentgoods);
        }
    }
}
