using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_Log_IntegralComm_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Sid { get; set; }
        public virtual Int64 Pid { get; set; }
        public virtual string Tm { get; set; }
        public virtual int VisitTimes { get; set; }
        public virtual int VisitLength { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual int Is_valid { get; set; }

        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }

        public virtual int Day90VisitTimes { get; set; }

        public virtual int Day90VisitLength { get; set; }
        
    }
}