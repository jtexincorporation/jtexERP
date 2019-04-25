namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductID { get; set; }

        public int? UnitID { get; set; }

        public int? StoreID { get; set; }

        public int? AccountID { get; set; }

        [Required]
        [StringLength(30)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(30)]
        public string Category { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Picture { get; set; }

        [StringLength(100)]
        public string PicturePath { get; set; }
    }
}
