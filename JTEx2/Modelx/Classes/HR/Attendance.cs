namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        [Key]
        public int att_ID { get; set; }

        public int EmployeeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CurrentDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeIn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TimeOut { get; set; }

        public byte? TotalTime { get; set; }

        public int? status_id { get; set; }
    }
}
