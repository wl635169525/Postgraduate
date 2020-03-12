using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface ISchool
    {
        IQueryable<School> GetSchoolbyRand(int top);
        IQueryable<School> GetSchoolBySuiJi(int top);
        IQueryable<School> GetSchoolBySuiJi2(int top);
        IQueryable<School> GetSchoolBySuiJi3(int top);
        IQueryable<School> GetSchoolBySuiJi4(int top);
        IQueryable<School> GetSchoolBySuiJi5(int top);
        IQueryable<School> GetSchoolBySuiJi6(int top);
        IQueryable<School> GetSchoolBySuiJi7(int top);
        IQueryable<School> GetSchoolBySuiJi8(int top);
        IQueryable<School> GetSchoolBySuiJi9(int top);
        School GetSchoolById(int? id);
    }
}
