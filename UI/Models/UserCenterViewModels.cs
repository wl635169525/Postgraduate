using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;


namespace UI.Models
{
    public class UserCenterViewModels
    {
        public UserInfo GetUserByID { get; set; }
        public IEnumerable<ShoppingCart> ShoppingCart1 { get; set; }
        //p/*ublic UserInfo Users { get; set; }*/
    }
}