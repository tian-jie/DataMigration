using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_CfgGroupQues_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Qid { get; set; }
        public virtual Int64 Group_id { get; set; }
        public virtual int Sort { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}