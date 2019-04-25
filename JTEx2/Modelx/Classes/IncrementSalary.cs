namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncrementSalary")]
    public partial class IncrementSalary
    {
        [Key]
        public int inc_id { get; set; }

        public int EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public long PreviousSalaary { get; set; }

        public int Amount { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }
}
