namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ArticleStatu
    {
        public long id { get; set; }

        public long doc { get; set; }

        [Required]
        [StringLength(50)]
        public string po { get; set; }

        public int articleid { get; set; }

        public byte statusid { get; set; }

        [StringLength(500)]
        public string remarks { get; set; }

        public virtual Article Article { get; set; }
    }
}
