namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shift
    {
        public int ShiftID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int Number { get; set; }

        public TimeSpan StartTime { get; set; }
    }
}
