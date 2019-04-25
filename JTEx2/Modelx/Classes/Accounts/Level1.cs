namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Level1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int L1_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        DataTable dt = new DataTable();
        ADOEntityModel db = new ADOEntityModel();
        public List<Level1> GetDepartments()
        {
            ADOEntityModel db = new ADOEntityModel();
            return db.Level1.ToList();
        }
        
        
    }
}
