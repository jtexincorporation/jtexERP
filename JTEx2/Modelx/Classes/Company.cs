namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        public int CompanyID { get; set; }

        public int GroupID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(30)]
        public string NTN { get; set; }

        [Required]
        [StringLength(30)]
        public string STN { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Website { get; set; }
    }
}
