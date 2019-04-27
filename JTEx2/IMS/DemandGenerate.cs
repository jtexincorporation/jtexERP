using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class DemandGenerate

    {
        [Key]
        public int Demand_id { get; set; }

        [StringLength(20)]
        [Required]
        public string Demand_po { get; set; }

        public int Demand_yarnID { get; set; }
        public int Demand_Bags { get; set; }
        public float Demand_netWeight { get; set; }
        public float Demand_GtWeight { get; set; }
    }
}
