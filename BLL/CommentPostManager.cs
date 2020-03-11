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
   public  class CommentPostManager
    {
        ICommentPost icommentpost = DataAccess.CreateCommentPost();
        public IEnumerable<Post_pl> GetPostCommentById(int id)
        {
            var Post_pl = icommentpost.GetPostCommentById(id);
            return Post_pl;
        }
        public void InsertPostComment(CommentPost commentpost)
        {
            icommentpost.InsertPostComment(commentpost);
        }
    }
}
