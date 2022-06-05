using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_OrdinaryHealthFile_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64? Pid { get; set; }
        public virtual DateTime? Created { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual int? Type { get; set; }
        public virtual string Insulin_gauge { get; set; }
        public virtual string Scheme { get; set; }
        public virtual string Before_breakfast { get; set; }
        public virtual string Before_lunch { get; set; }
        public virtual string Before_dinner { get; set; }
        public virtual string Before_sleep { get; set; }
        public virtual string Code { get; set; }

        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}