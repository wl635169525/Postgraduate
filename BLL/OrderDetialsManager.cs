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
   public  class OrderDetialsManager
    {
        IOrderDetials iorderdetials = DataAccess.CreateOrderDetials();
    }
}
