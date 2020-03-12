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
    public class SqlReplyCommentCourse:IReplyCommentCourse
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Course_hf> GetCourseReplyById(int id)
        {
            var Course_hf = db.Course_hf.Where(a => a.CCourseID == id);
            return Course_hf;
        }
       public void InsertCourseReply(ReplyCommentCourse replycourse)
        {
            db.ReplyCommentCourse.Add(replycourse);
            db.SaveChanges();
        }
    }
}
