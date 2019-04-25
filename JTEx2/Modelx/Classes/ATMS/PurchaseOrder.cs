namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PurchaseOrder
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal doc { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal id { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime date { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string po { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int client { get; set; }

        [StringLength(50)]
        public string packing { get; set; }

        [StringLength(50)]
        public string ticketing { get; set; }

        [StringLength(50)]
        public string paymentterm { get; set; }

        [StringLength(50)]
        public string polybag { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int articleid { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int qty { get; set; }

        [Key]
        [Column(Order = 7)]
        public double price { get; set; }

        [StringLength(50)]
        public string priceby { get; set; }

        public byte? season { get; set; }

        [Column(TypeName = "date")]
        public DateTime? delivery { get; set; }

        [Column(TypeName = "date")]
        public DateTime? commentsDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? approvalDate { get; set; }

        [StringLength(100)]
        public string Comments { get; set; }

        [StringLength(100)]
        public string FeedBack { get; set; }

        [StringLength(100)]
        public string WillShip { get; set; }

        [StringLength(200)]
        public string remarks { get; set; }

        public byte? status { get; set; }

        public /*virtual*/ Article Article { get; set; }

        public /*virtual*/ Client Client1 { get; set; }

        public /*virtual*/ Season Season1 { get; set; }
    }
}
