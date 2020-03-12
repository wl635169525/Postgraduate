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
   public  class SqlPost:IPost
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public  IEnumerable<PostShow> GetPostById(int id)
        {
            var PostShow = db.PostShow.Where(a => a.PostID == id);
            return PostShow;
        }

        public void InsertPost(Post post)
        {
            db.Post.Add(post);
            db.SaveChanges();
        }
        public IEnumerable<PostShow> GetPost()
        {
            var post = db.PostShow.ToList();
            return post;
        }
    }
}
