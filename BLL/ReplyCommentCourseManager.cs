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
    public  class ReplyCommentCourseManager
    {
        IReplyCommentCourse ireplycommentcourse = DataAccess.CreateReplyCommentCourse();

        public IEnumerable<Course_hf> GetCourseReplyById(int id)
        {
            var Course_hf = ireplycommentcourse.GetCourseReplyById(id);
            return Course_hf;
        }
        public void InsertCourseReply(ReplyCommentCourse replycourse)
        {
            ireplycommentcourse.InsertCourseReply(replycourse);
        }
    }
}
