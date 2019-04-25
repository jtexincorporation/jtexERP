namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loan")]
    public partial class Loan
    {
        [Key]
        public int l_id { get; set; }

        public int EmployeeID { get; set; }

        public int Amount { get; set; }

        public byte Partitions { get; set; }

        [Column(TypeName = "date")]
        public DateTime issueDate { get; set; }

        public int RemainingAmount { get; set; }

        public bool Clear { get; set; }
    }
}
