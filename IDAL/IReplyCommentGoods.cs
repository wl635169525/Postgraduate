using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public  interface IReplyCommentGoods
    {
        IEnumerable<Goods_hf> GetGoodsReplyById(int id);

        void InsertGoodReply(ReplyCommentGoods replygoods);
    }
}
