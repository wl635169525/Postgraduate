using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
   public  interface ICommentPost
    {
        IEnumerable<Post_pl> GetPostCommentById(int id);

        void InsertPostComment(CommentPost commentpost);
    }
}
