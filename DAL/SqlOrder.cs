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
   public  class SqlOrder:IOrder
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
    }
}
