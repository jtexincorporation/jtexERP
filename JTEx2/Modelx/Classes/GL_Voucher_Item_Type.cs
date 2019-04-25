namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GL_Voucher_Item_Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte VoucherItemID { get; set; }

        public int? AccountID { get; set; }

        public long? Debit { get; set; }

        public long? Credit { get; set; }

        [StringLength(50)]
        public string Narration { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
