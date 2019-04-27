namespace IMS
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IMSEntityModel : DbContext
    {
        public IMSEntityModel()
            : base("name=IMSEntityModel")
        {
        }
        public virtual DbSet<yDefine> YDefines { get; set; }
        public virtual DbSet<DemandGenerate> DemandGenerates { get; set; }
        public virtual DbSet<YarnStock> YarnStocks { get; set; }



        
    }

    
}