using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace UI.Models
{
    public class LunTanViewModels
    {
        public IEnumerable<PostShow> postdetail { get; set; }
        public IEnumerable<PostShow> post1 { get; set; }
        public IEnumerable<Post_pl> PostComment { get; set; }
        public IEnumerable<Post_hf> PostReply { get; set; }
    }
}