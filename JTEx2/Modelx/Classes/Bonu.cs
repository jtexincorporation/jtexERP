namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bonu
    {
        [Key]
        public int Bon_ID { get; set; }

        public int EmployeeID { get; set; }

        public long Salary { get; set; }

        [Column(TypeName = "date")]
        public DateTime Month { get; set; }

        public int BonusAmount { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
