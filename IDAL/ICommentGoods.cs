using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
  public   interface ICommentGoods
    {
        IEnumerable<Goods_pl> GetGoodsCommentById(int id);

        void InsertGoodsComment(CommentGoods commentgoods);
    }
}
