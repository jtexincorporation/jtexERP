namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Level4
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int L4_id { get; set; }

        public int L3_id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }
    }
}
