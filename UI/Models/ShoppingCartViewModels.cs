using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace UI.Models
{
    public class ShoppingCartViewModels
    {
        public IEnumerable<shopping_cart> shopping_cart { get; set; }
        public IEnumerable<ShoppingCart> ShoppingCart1 { get; set; }
    }
}