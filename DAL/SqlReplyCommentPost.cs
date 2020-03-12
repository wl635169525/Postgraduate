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
  public   class SqlReplyCommentPost:IReplyCommentPost
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Post_hf> GetPostReplyById(int id)
        {
            var Post_hf = db.Post_hf.Where(a => a.CPostID == id);
            return Post_hf;
        }
        public  void InsertPostReply(ReplyCommentPost replypost)
        {
            db.ReplyCommentPost.Add(replypost);
            db.SaveChanges();
        }
    }
  
}
