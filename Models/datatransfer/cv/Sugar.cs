using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_Sugar_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual string Result { get; set; }
        public virtual string Value { get; set; }
        public virtual string Imei { get; set; }
        public virtual string Hp_uid { get; set; }
        public virtual string Time { get; set; }
        public virtual int? Time_range { get; set; }
        public virtual int? Level { get; set; }
        public virtual string Record_id { get; set; }
        public virtual string Remark { get; set; }
        public virtual string AccountId { get; set; }
        public virtual int? Cv_level { get; set; }
        public virtual string Pid { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}