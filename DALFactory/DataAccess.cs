using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using IDAL;
namespace DALFactory
{
   public  class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();

        public static IUserInfo CreateUserInfo()
        {
            string className = AssemblyName + "." + db + "UserInfo";
            return (IUserInfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static  ICarousel CreateCarousel()
        {
            string className = AssemblyName + "." + db + "Carousel";
            return (ICarousel)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static ICommentCourse CreateCommentCourse()
        {
            string className = AssemblyName + "." + db + "CommentCourse";
            return (ICommentCourse)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static ICommentGoods CreateCommentGoods()
        {
            string className = AssemblyName + "." + db + "CommentGoods";
            return (ICommentGoods)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static ICommentPost CreateCommentPost()
        {
            string className = AssemblyName + "." + db + "CommentPost";
            return (ICommentPost)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static ICourse CreateCourse()
        {
            string className = AssemblyName + "." + db + "Course";
            return (ICourse)Assembly.Load(AssemblyName).CreateInstance(className);

        }

        public static IGoods CreateGoods()
        {
            string className = AssemblyName + "." + db + "Goods";
            return (IGoods)Assembly.Load(AssemblyName).CreateInstance(className);

        }

        public static INews CreateNews()
        {
            string className = AssemblyName + "." + db + "News";
            return (INews)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IOrder CreateOrder()
        {
            string className = AssemblyName + "." + db + "Order";
            return (IOrder)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IOrderDetials CreateOrderDetials()
        {
            string className = AssemblyName + "." + db + "OrderDetials";
            return (IOrderDetials)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IPost CreatePost()
        {
            string className = AssemblyName + "." + db + "Post";
            return (IPost)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IReplyCommentCourse CreateReplyCommentCourse()
        {
            string className = AssemblyName + "." + db + "ReplyCommentCourse";
            return (IReplyCommentCourse)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IReplyCommentGoods CreateReplyCommentGoods()
        {
            string className = AssemblyName + "." + db + "ReplyCommentGoods";
            return (IReplyCommentGoods)Assembly.Load(AssemblyName).CreateInstance(className);

        }

        public static IReplyCommentPost CreateReplyCommentPost()
        {
            string className = AssemblyName + "." + db + "ReplyCommentPost";
            return (IReplyCommentPost)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static ISchool CreateSchool()
        {
            string className = AssemblyName + "." + db + "School";
            return (ISchool)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IShoppingCart CreateShoppingCart()
        {
            string className = AssemblyName + "." + db + "ShoppingCart";
            return (IShoppingCart)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IStrategy CreateStrategy()
        {
            string className = AssemblyName + "." + db + "Strategy";
            return (IStrategy)Assembly.Load(AssemblyName).CreateInstance(className);
        }

}
}
