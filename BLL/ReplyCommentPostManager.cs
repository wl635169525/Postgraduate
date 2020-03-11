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
   public  class ReplyCommentPostManager
    {
        IReplyCommentPost ireplycommentpost = DataAccess.CreateReplyCommentPost();
        public IEnumerable<Post_hf> GetPostReplyById(int id) 
        {
            var Post_hf = ireplycommentpost.GetPostReplyById(id);
            return Post_hf;
        }

        public void InsertPostReply(ReplyCommentPost replypost)
        {
            ireplycommentpost.InsertPostReply(replypost);
        }
    }
}
