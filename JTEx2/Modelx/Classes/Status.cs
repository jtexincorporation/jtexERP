namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        [Key]
        public int status_id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }
    }
}
