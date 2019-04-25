namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        public int DepartmentID { get; set; }

        public int? UnitID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Abbrevation { get; set; }
    }
}
