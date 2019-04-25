namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        public int SupplierID { get; set; }

        public int? AccountID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Category { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(30)]
        public string ContactPerson { get; set; }

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
