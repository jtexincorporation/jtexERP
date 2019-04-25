namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GatePass")]
    public partial class GatePass
    {
        [Key]
        public int GPID { get; set; }

        public int? AccountID { get; set; }

        public int? PartyID { get; set; }

        [StringLength(30)]
        public string GPNumber { get; set; }

        [StringLength(30)]
        public string GPCategory { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(30)]
        public string DriverName { get; set; }

        [StringLength(30)]
        public string VehicleNumber { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }
    }
}
