//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            this.CommentGoods = new HashSet<CommentGoods>();
            this.OrderDetials = new HashSet<OrderDetials>();
            this.ShoppingCart = new HashSet<ShoppingCart>();
        }
    
        public int GoodsID { get; set; }
        public string GoodsName { get; set; }
        public string GoodsPhoto { get; set; }
        public string SubPrice { get; set; }
        public string Price { get; set; }
        public string GoodsIntroduce { get; set; }
        public string Number { get; set; }
        public string GoodsPhoto1 { get; set; }
        public string GoodsPhoto2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentGoods> CommentGoods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetials> OrderDetials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}