using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_CfgQues_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual string Title { get; set; }
        public virtual string Keyword { get; set; }
        public virtual int Type { get; set; }
        public virtual string Code { get; set; }
        public virtual string Unit { get; set; }
        public virtual string Max_val { get; set; }
        public virtual string Min_val { get; set; }
        public virtual string Default_val { get; set; }
        public virtual int? Iffloat { get; set; }
        public virtual int? Seq { get; set; }
        public virtual string Son_type { get; set; }
        public virtual int? Files_code { get; set; }
        public virtual string Help { get; set; }
        public virtual string Label { get; set; }
        public virtual string Answer { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual int? Tag { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}