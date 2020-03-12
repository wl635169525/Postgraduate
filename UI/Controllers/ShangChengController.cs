using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace UI.Controllers
{
    public class ShangChengController : Controller
    {
        // GET: ShangCheng
        YanShenWangEntities db = new YanShenWangEntities();
        GoodsManager goodsManager = new GoodsManager();
        CommentGoodsManager commentgoodsManager = new CommentGoodsManager();
        ReplyCommentGoodsManager replygoodsManager = new ReplyCommentGoodsManager();
        ShoppingCartManager shoppingCartManager = new ShoppingCartManager();


        #region 商城首页
        public ActionResult ShangChengIndex()
        {
            var goods1 = goodsManager.GetGoodsbyTopID(8);
            Models.ShangChengViewModels Vm = new Models.ShangChengViewModels();
            Vm.Goods1 = goods1;
            
            return View(Vm);
        }
        #endregion
        #region 商场详情页
        public ActionResult ShangChengDetails(int goodsid)
        {
            Session["GoodsID"] = goodsid;
            int Goods_id = Convert.ToInt32(Session["GoodsID"]);
            Models.ShangChengViewModels Vm = new Models.ShangChengViewModels();
            var goods = goodsManager.GetGoodsById(Goods_id);
            Session["Price"] = goods.Price;
            if (goods == null)
            {
                return HttpNotFound();
            }
            Vm.GetGoodsByID = goods;
            return View(Vm);
        }
        #endregion

        #region 购物车
        public ActionResult ShoppingCart()
        {
            Models.ShoppingCartViewModels Vm = new Models.ShoppingCartViewModels();
            int usrid = Convert.ToInt32(Session["UserID"]);
            var shopcar = shoppingCartManager.GetShopCartById(usrid);
            Vm.shopping_cart = shopcar;
            return View(Vm);
        }
     
        #endregion

        #region 加购物车
        [HttpPost]

        public ActionResult AddShoppingCar(ShoppingCart shopping)
        {
            int GoodsID = Convert.ToInt32(Session["GoodsID"]);
            int UserID = Convert.ToInt32(Session["UserID"]);
            if (UserID <= 0)//判断用户是否登入
            {
                return Redirect("/UserInfo/Login");
            }

            else
            {
                
                try
                {
                    var shoppingCart = shoppingCartManager.Judge(UserID, GoodsID);
                    if (shoppingCart != null)//判断购物车是否存在该商品
                    {
                        return Content("<script>;alert('该商品已添加进购物车!');history.go(-1)</script>");

                    }
                    else//向购物车中插入一条记录
                    {
                        int Numbers = 1;
                        shopping.UserID = UserID;
                        shopping.GoodsID = GoodsID;
                        shopping.Number = Numbers;
                        shopping.Price = Convert.ToInt32(Session["Price"]);              
                        shopping.flag = 0;
                        shoppingCartManager.AddShoppingCart(shopping);
                        return Content("<script>;alert('添加成功!');history.go(-1)</script>");
                    }
                }
              catch(Exception ex)
                {
                    return Content(ex.Message);
                }
                
            }       
        }
        #endregion

        #region 商品评论
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult GoodsComment(CommentGoods goodscomment)
        {
            int GoodsID = Convert.ToInt32(Session["GoodsID"]);
            goodscomment.CGContent = Request.Form["GooodsCommentContent"];
            if (goodscomment.CGContent == "")
            {
                return Content("");
            }
            else
            {
                goodscomment.UserID = Convert.ToInt32(Session["UserID"]);
                goodscomment.GoodsID = Convert.ToInt32(Session["GoodsID"]);
                goodscomment.CGTime = DateTime.Now;
                commentgoodsManager.InsertGoodsComment(goodscomment);
                return Content("");

            }
        }
        #endregion
        #region 商品评论回复
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult GoodsReply(ReplyCommentGoods goodsreply, int GoodsCommentID)
        {
            int GoodsID = Convert.ToInt32(Session["GoodsID"]);
            goodsreply.RCGContent = Request.Form["GoodsReplyContent"];
            if (goodsreply.RCGContent == "")
            {
                return Content("");
            }
            else
            {
                goodsreply.UserID = Convert.ToInt32(Session["UserID"]);
                goodsreply.CGoodsID = GoodsCommentID;
                goodsreply.RCGTime = DateTime.Now;
                replygoodsManager.InsertGoodReply(goodsreply);
                return Content("");
            }

        }
        #endregion
    }
}