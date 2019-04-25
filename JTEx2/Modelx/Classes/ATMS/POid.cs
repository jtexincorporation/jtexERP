namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("POid")]
    public partial class POid
    {
        [Key]
        public long docid { get; set; }

        public byte userid { get; set; }
    }
}
