using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;

namespace IDAL
{
  public   interface IGoods
    {
        IQueryable<Goods> GetGoodsByTopID(int top);
        Goods GetGoodsById(int? id);
    }
}
