namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte BankID { get; set; }

        public int? AccountID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(30)]
        public string AccountNumber { get; set; }

        [StringLength(30)]
        public string IBANNumber { get; set; }

        [StringLength(50)]
        public string AccountTitle { get; set; }

        [StringLength(30)]
        public string SwiftCode { get; set; }
    }
}
