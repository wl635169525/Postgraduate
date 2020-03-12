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
   public  class SqlCommentPost:ICommentPost
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();

        public IEnumerable<Post_pl> GetPostCommentById(int id)
        {
            var Post_pl = db.Post_pl.Where(a => a.PostID == id);
            return Post_pl;
        }

        public void InsertPostComment(CommentPost commentpost)
        {
            db.CommentPost.Add(commentpost);
            db.SaveChanges();
        }
    }
}
