using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
  public   interface IShoppingCart
    {
        void AddShoppingCart(ShoppingCart shoppingCart);
        ShoppingCart Judge(int UserID,int GoodsID);
        void UpdateShoppingCart(ShoppingCart shoppingCart);

        ShoppingCart GetShoppingCartById(int? id);

        IEnumerable<shopping_cart> GetShopCartById(int id);

      

    }
}
