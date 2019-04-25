namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subsection")]
    public partial class Subsection
    {
        public int SubsectionID { get; set; }

        public int SectionID { get; set; }

        public int Number { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Abbrevation { get; set; }
    }
}
