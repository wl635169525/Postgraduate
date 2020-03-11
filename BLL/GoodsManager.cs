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
   public  class GoodsManager
    {
        IGoods igoods = DataAccess.CreateGoods();
        public IQueryable<Goods> GetGoodsbyTopID(int top)
        {
            var goods = igoods.GetGoodsByTopID(top);
            return goods;
        }
        public Goods GetGoodsById(int? id)
        {
            Goods goods = igoods.GetGoodsById(id);
            return goods;
        }
}}
