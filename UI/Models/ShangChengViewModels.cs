using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace UI.Models
{
    public class ShangChengViewModels
    {
        public IEnumerable<Goods>Goods1{ get; set; }
        public Goods GetGoodsByID { get; set; }
        public IEnumerable<Goods_pl> GoodsComment { get; set; }

        public IEnumerable<Goods_hf> GoodsReply { get; set; }

        public ShoppingCart shoppingCart1 { get; set; }
    }
}