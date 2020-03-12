using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;


namespace UI.Controllers
{
    public class LunTanController : Controller
    {
        YanShenWangEntities db = new YanShenWangEntities();
        PostManager postManager = new PostManager();
        CommentPostManager commentpostManager = new CommentPostManager();
        ReplyCommentPostManager replypostManager = new ReplyCommentPostManager();

        #region 论坛首页
        public ActionResult LunTanIndex()
        {
            Models.LunTanViewModels Vm = new Models.LunTanViewModels();
            var post1 = postManager.GetPost();
            Vm.post1 = post1;
            return View(Vm);
        }
        #endregion

        #region 帖子详情页
        public ActionResult PostDetail(int postid)
        {
            Models.LunTanViewModels Vm = new Models.LunTanViewModels();
            Session["PostID"] = postid;
            var posts = postManager.GetPostById(postid);
            var postcomment = commentpostManager.GetPostCommentById(postid);

            Vm.postdetail = posts;
            Vm.PostComment = postcomment;

            if (posts == null)
            {
                return HttpNotFound();
            }
            return View(Vm); 
        }
        #endregion

        #region 发布帖子
        public ActionResult Post()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Post(Post post)
        {
            int UserID = Convert.ToInt32(Session["UserID"]);
            post.PostContent = Request.Form["PostContent"];
            if (post.PostContent == "")
            {
                return Content("<script>;alert('帖子内容不能为空');window.open('" + Url.Action("Post", "LunTan") + "', '_self' </script>");
            }
            else
            {
                post.PostName = Request.Form["PostTitle"];
                post.UserID = UserID;
                post.PostTime = DateTime.Now;
                postManager.InsertPost(post);
                return RedirectToAction("LunTanIndex", "LunTan");
            }
        }
        #endregion
        #region 帖子评论
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PostComment(CommentPost postcomment)
        {
            int PostID = Convert.ToInt32(Session["PostID"]);
            int UserID = Convert.ToInt32(Session["UserID"]);
            postcomment.CPContent = Request.Form["PostCommentContent"];

            if (postcomment.CPContent == "")
            {
                return Content("<script>;alert('评论内容不能为空'); '_self' </script>");
            }

            else
            {
                postcomment.UserID = UserID;
                postcomment.PostID = PostID;
                postcomment.CPTime = DateTime.Now;
                commentpostManager.InsertPostComment(postcomment);
                return Content("");

            }
        }
        #endregion

        #region 帖子回复
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult PostReply(ReplyCommentPost postreply, int PostCommentID)
        {
            int PostID = Convert.ToInt32(Session["PostID"]);
            postreply.RCPostContent = Request.Form["PostReplyContent"];
            if (postreply.RCPostContent == "")
            {
                return Content("");
            }

            else
            {
                postreply.UserID = Convert.ToInt32(Session["UserID"]);
                postreply.CPostID = PostCommentID;
                postreply.RCPostTime = DateTime.Now;
                replypostManager.InsertPostReply(postreply);
                return Content("");

            }
        }
        #endregion
    }
}