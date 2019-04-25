namespace Modelx
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bin
    {
        public int BinID { get; set; }

        public int? StoreID { get; set; }

        [StringLength(30)]
        public string RackNumber { get; set; }

        [StringLength(30)]
        public string RowNumber { get; set; }

        [StringLength(30)]
        public string ShelfNumber { get; set; }
    }
}
