using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace IDAL
{
   public  interface IReplyCommentPost
    {
        IEnumerable<Post_hf> GetPostReplyById(int id);

        void InsertPostReply(ReplyCommentPost replypost);
    }
}
