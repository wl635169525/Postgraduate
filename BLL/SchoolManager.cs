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
    public class SchoolManager
    {
        ISchool ischool = DataAccess.CreateSchool();
        public IQueryable<School> GetSchoolbyRand(int top)
        {
            var school = ischool.GetSchoolbyRand(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi(int top)
        {
            var school = ischool.GetSchoolBySuiJi(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi2(int top)
        {
            var school = ischool.GetSchoolBySuiJi2(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi3(int top)
        {
            var school = ischool.GetSchoolBySuiJi3(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi4(int top)
        {
            var school = ischool.GetSchoolBySuiJi4(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi5(int top)
        {
            var school = ischool.GetSchoolBySuiJi5(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi6(int top)
        {
            var school = ischool.GetSchoolBySuiJi6(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi7(int top)
        {
            var school = ischool.GetSchoolBySuiJi7(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi8(int top)
        {
            var school = ischool.GetSchoolBySuiJi9(top);
            return school;
        }
        public IQueryable<School> GetSchoolBySuiJi9(int top)
        {
            var school = ischool.GetSchoolBySuiJi9(top);
            return school;
        }
        public School GetSchoolById(int? id)
        {
            School school = ischool.GetSchoolById(id);
            return school;
        }
    }
}
