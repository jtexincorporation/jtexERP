namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GL_Voucher
    {
        [Key]
        public int VoucherID { get; set; }

        public int? PartyID { get; set; }

        [StringLength(20)]
        public string VoucherNumber { get; set; }

        [StringLength(30)]
        public string VoucherType { get; set; }

        [StringLength(50)]
        public string Refrence { get; set; }

        public int? CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public int? LastUpdatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastUpdatedDate { get; set; }

        public int? CanceledBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CanceledDate { get; set; }

        public int? ApprovedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApprovedDate { get; set; }

        public int? CheckedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckedDate { get; set; }

        [StringLength(30)]
        public string VoucherStatus { get; set; }

        public bool? isActive { get; set; }

        public int? GroupID { get; set; }

        public int? CompanyID { get; set; }

        public int? BranchID { get; set; }

        public int? UnitID { get; set; }

        public int? DepartmentID { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }
    }
}
