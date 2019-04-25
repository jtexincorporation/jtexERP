namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class File
    {
        public long id { get; set; }

        public int ArticleID { get; set; }

        public DateTime date { get; set; }

        [Required]
        [StringLength(500)]
        public string FileName { get; set; }

        [Required]
        [StringLength(5000)]
        public string SourcePath { get; set; }

        [Required]
        [StringLength(5000)]
        public string DestinationPath { get; set; }

        [Required]
        [StringLength(50)]
        public string FileType { get; set; }
    }
}
