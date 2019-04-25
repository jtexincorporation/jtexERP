namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urdu")]
    public partial class Urdu
    {
        [Key]
        public int u_id { get; set; }

        [Column("urdu")]
        [Required]
        [StringLength(200)]
        public string urdu1 { get; set; }
    }
}
