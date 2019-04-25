namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            ArticleStatus = new HashSet<ArticleStatu>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int ArticleID { get; set; }

        [Required]
        [StringLength(50)]
        public string StyleNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string PriceBy { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public byte Gender { get; set; }

        public byte Color { get; set; }

        [StringLength(50)]
        public string Comp { get; set; }

        public double? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public byte? Currency { get; set; }

        [Column(TypeName = "text")]
        public string PicturePath { get; set; }

        public bool isActive { get; set; }

        public byte Brand { get; set; }

        public virtual Brand Brand1 { get; set; }

        public virtual Color Color1 { get; set; }

        public virtual Currency Currency1 { get; set; }

        public virtual Gender Gender1 { get; set; }

        public virtual Size Size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleStatu> ArticleStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
