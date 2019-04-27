using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class YarnStock
    {
        [Key]
        public int StoreID { get; set; }
        public int YarnID { get; set; }

        [StringLength(20)]
        [Required]
        public string Yarn_Po { get; set; }

        public int PartyID { get; set; }
        public int YarnsBags { get; set; }
        public int yarnGatepass { get; set; }

        [StringLength(20)]
        [Required]
        public string GP_Category { get; set; }
        public float YarnNetweighy { get; set; }

        [StringLength(100)]
        [Required]
        public string Description { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        [StringLength(20)]
        [Required]
        public string Category { get; set; }
        public int Amount { get; set; }

        [StringLength(50)]
        [Required]
        public string DriverName { get; set; }

        [StringLength(20)]
        [Required]
        public string VehicleNumber { get; set; }

        [StringLength(20)]
        [Required]
        public string Department { get; set; }
        public int AccountID { get; set; }

    }
}
