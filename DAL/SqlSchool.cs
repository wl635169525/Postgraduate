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
    public class SqlSchool : ISchool
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public IQueryable<School> GetSchoolbyRand(int top)
        {
            var school = (from yuanxiao in db.School
                          orderby Guid.NewGuid()
                          select yuanxiao).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi(int top)
        {
            var school = (from yuanxiao1 in db.School
                          orderby Guid.NewGuid()
                          select yuanxiao1).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi2(int top)
        {
            var school = (from yuanxiao2 in db.School
                          where yuanxiao2.Sort == "4"
                          orderby Guid.NewGuid()
                          select yuanxiao2).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi3(int top)
        {
            var school = (from yuanxiao3 in db.School
                          orderby Guid.NewGuid()
                          select yuanxiao3).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi4(int top)
        {
            var school = (from yuanxiao4 in db.School
                          orderby Guid.NewGuid()
                          select yuanxiao4).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi5(int top)
        {
            var school = (from yuanxiao5 in db.School
                          where yuanxiao5.Sort=="1"
                          orderby Guid.NewGuid()
                          select yuanxiao5).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi6(int top)
        {
            var school = (from yuanxiao6 in db.School
                          where yuanxiao6.Sort == "2"
                          orderby Guid.NewGuid()
                          select yuanxiao6).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi7(int top)
        {
            var school = (from yuanxiao7 in db.School
                          where yuanxiao7.Sort == "3"
                          orderby Guid.NewGuid()
                          select yuanxiao7).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi8(int top)
        {
            var school = (from yuanxiao8 in db.School
                          where yuanxiao8.Sort == "4"
                          orderby Guid.NewGuid()
                          select yuanxiao8).Take(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi9(int top)       
        {
            var school = (from yuanxiao9 in db.School
                          where yuanxiao9.Sort == "5"
                          orderby Guid.NewGuid()
                          select yuanxiao9).Take(top);
            return school;
        }

    public School GetSchoolById(int? id)
        {
            School school = db.School.Find(id);
            return school;
        }
    }
}
