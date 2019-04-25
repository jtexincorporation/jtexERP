namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeaveBalance")]
    public partial class LeaveBalance
    {
        [Key]
        public int lb_id { get; set; }

        public int EmployeeID { get; set; }

        public short Year { get; set; }

        public short NOL { get; set; }
    }
}
