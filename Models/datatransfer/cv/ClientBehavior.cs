using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_ClientBehavior_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual string Agent { get; set; }
        public virtual string Device { get; set; }
        public virtual string Url { get; set; }
        public virtual string Arg { get; set; }
        public virtual Int64 Visit_tm { get; set; }
        public virtual int? Time { get; set; }
        public virtual string Page_id { get; set; }
        public virtual string Simuid { get; set; }
        public virtual string Referer { get; set; }
        public virtual string Cookie_id { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}