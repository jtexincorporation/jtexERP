namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArticleBarcode")]
    public partial class ArticleBarcode
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int articleid { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte sizeid { get; set; }

        public short? qty { get; set; }

        [StringLength(50)]
        public string barcode { get; set; }

        public virtual Size Size { get; set; }
    }
}
