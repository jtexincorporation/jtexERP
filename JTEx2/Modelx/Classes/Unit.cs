namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Unit")]
    public partial class Unit
    {
        public int UnitID { get; set; }

        public int BranchID { get; set; }

        public int Number { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Abbrevation { get; set; }
    }
}
