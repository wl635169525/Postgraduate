using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace UI.Models
{
    public class StrategyViewModel
    {
        public IEnumerable<Strategy> Strategy1 { get; set; }
        public IEnumerable<Strategy> Strategy2 { get; set; }
    }
}