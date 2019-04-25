using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelx.Classes.Accounts
{
   public partial class Level5
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int L5_id { get; set; }

        public int L4_id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }
    }
}
