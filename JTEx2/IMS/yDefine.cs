using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class yDefine
    {
        [Key]
        public int Yarn_id { get; set; }

        [StringLength(20)]
        [Required]
        public string Type { get; set; }

        [StringLength(20)]
        [Required]
        public string Count { get; set; }

        [StringLength(20)]
        [Required]
        public string BrandName { get; set; }
        
        public int L4_id { get; set; }

        [StringLength(20)]
        [Required]
        public string ItemType { get; set; }

        [StringLength(20)]
        [Required]
        public string isActive { get; set; }


    }
}
