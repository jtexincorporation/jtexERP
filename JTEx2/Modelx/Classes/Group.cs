namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Group
    {
        public int GroupID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int Number { get; set; }
    }
}
