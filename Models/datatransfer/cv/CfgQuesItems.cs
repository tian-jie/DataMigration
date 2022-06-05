using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_CfgQuesItems_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Qid { get; set; }
        public virtual int Seq { get; set; }
        public virtual string Value { get; set; }
        public virtual string Con { get; set; }
        public virtual string Help { get; set; }
        public virtual int? Type { get; set; }
        public virtual string Max_rule { get; set; }
        public virtual string Min_rule { get; set; }
        public virtual string Motions { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}