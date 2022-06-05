using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_Patient_Relatives_Remind_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Sid { get; set; }
        public virtual Int64 Pid { get; set; }
        public virtual Int64 Simuid { get; set; }
        public virtual int Type { get; set; }
        public virtual string Content { get; set; }
        public virtual int Channel { get; set; }

        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }


    }
}