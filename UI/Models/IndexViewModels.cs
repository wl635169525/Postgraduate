using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace UI.Models
{
    public class IndexViewModels
    {
        public IEnumerable<School> School1 { get; set; }
        public IEnumerable<Course> Course1 { get; set; }
        public IEnumerable<News> News1 { get; set; }
        public IEnumerable<Strategy> Strategy1 { get; set; }
        public IEnumerable<Carousel> Carousel1{ get; set; }
    }  
}