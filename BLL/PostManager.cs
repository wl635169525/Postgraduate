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
   public  class PostManager
    {
        IPost ipost = DataAccess.CreatePost();
        public IEnumerable<PostShow> GetPostById(int id)
        {
            var postshow = ipost.GetPostById(id);
            return postshow;
        }
        public void InsertPost(Post post)
        {
            ipost.InsertPost(post);
            
        }
        public  IEnumerable<PostShow> GetPost()
        {
            var post = ipost.GetPost();
            return post;

        }
    }
}
