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
   public  class ShoppingCartManager
    {
        IShoppingCart ishoppingcart = DataAccess.CreateShoppingCart();

       public  void AddShoppingCart(ShoppingCart shoppingCart)
        {
            ishoppingcart.AddShoppingCart(shoppingCart);
        }
       public  ShoppingCart Judge(int UserID, int GoodsID)
        {
            var shoppingCart = ishoppingcart.Judge(UserID, GoodsID);
            return shoppingCart;
        }
       public  void UpdateShoppingCart(ShoppingCart shoppingCart)
        {
            ishoppingcart.UpdateShoppingCart(shoppingCart);
        }

        public ShoppingCart GetShoppingCartById(int? id)
        {
            var shoppingCart = ishoppingcart.GetShoppingCartById(id);
            return shoppingCart;
        }

        public IEnumerable<shopping_cart> GetShopCartById(int id)
        {
            var shopping_cart = ishoppingcart.GetShopCartById(id);
            return shopping_cart;
        }
    }
}
