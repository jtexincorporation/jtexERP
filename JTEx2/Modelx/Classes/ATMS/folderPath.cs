namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("folderPath")]
    public partial class folderPath
    {
        [Key]
        [StringLength(50)]
        public string fPath { get; set; }
    }
}
