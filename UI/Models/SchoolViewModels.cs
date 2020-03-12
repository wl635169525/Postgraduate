using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace UI.Models
{
    public class SchoolViewModels
    {
        public IEnumerable<School> School1 { get; set; }
        public IEnumerable<School> School2 { get; set; }
        public IEnumerable<School> School3 { get; set; }
        public IEnumerable<School> School4 { get; set; }
        public School GetSchoolByID { get; set; }
        public IEnumerable<School> ChuanMei { get; set; }
        public IEnumerable<School> YiXue { get; set; }
        public IEnumerable<School> ShiFan{ get; set; }
        public IEnumerable<School> LiGong { get; set; }
        public IEnumerable<School> JinRong { get; set; }
    }
}