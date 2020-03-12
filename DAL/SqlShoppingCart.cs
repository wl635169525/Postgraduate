using System;
using System.Collections.Generic;
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
   public  class SqlShoppingCart:IShoppingCart
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
      public void AddShoppingCart(ShoppingCart shoppingCart)
        {
            db.ShoppingCart.Add(shoppingCart);
            db.SaveChanges();
        }
       public  ShoppingCart Judge(int UserID, int GoodsID)
        {
            var shoppingCart = db.ShoppingCart.Where(s => s.UserID == UserID).Where
                (s => s.GoodsID == GoodsID).FirstOrDefault();
            return shoppingCart;
                
        }
        public void UpdateShoppingCart(ShoppingCart shoppingCart)
        {
            db.Entry(shoppingCart).State = EntityState.Modified;
            db.SaveChanges();
        }

        public ShoppingCart GetShoppingCartById(int? id)
        {
            ShoppingCart shoppingcart = db.ShoppingCart.Find(id);
            return shoppingcart;
        }
        public IEnumerable<shopping_cart> GetShopCartById(int id)
        {
            var shopping_cart = db.shopping_cart.Where(a => a.UserID == id);

            return shopping_cart;
        }
    }
}
