namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            LoginSecurities = new HashSet<LoginSecurity>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int clientid { get; set; }

        public int? L4_id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string contact { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string web { get; set; }

        public bool isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public /*virtual*/ ICollection<LoginSecurity> LoginSecurities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public /*virtual*/ ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
