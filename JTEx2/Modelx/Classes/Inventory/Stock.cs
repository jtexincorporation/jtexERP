namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        [Key]
        public int Stock_id { get; set; }

        public int? ProductID { get; set; }

        public int? BinID { get; set; }

        public int? GPID { get; set; }

        [StringLength(30)]
        public string EnteryType { get; set; }

        public int? Qty { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
