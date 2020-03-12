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
   public  class SqlCommentCourse:ICommentCourse
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Course_pl> GetCourseCommentById(int id) /*查找评论*/
        {
            var Course_pl = db.Course_pl.Where(a => a.CourseID == id);
            return Course_pl;
        }

       public  void InsertCourseComment(CommentCourse commentcourse)
        {
            db.CommentCourse.Add(commentcourse);
            db.SaveChanges();
        }
    }

}
