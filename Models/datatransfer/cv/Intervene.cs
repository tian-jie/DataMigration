using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_Intervene_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual int? Patient_id { get; set; }
        public virtual Int64 Gid { get; set; }
        public virtual int Type { get; set; }
        public virtual DateTime Overdue { get; set; }
        public virtual Int64 Tid { get; set; }
        public virtual int Status { get; set; }
        public virtual string Conditions { get; set; }
        public virtual string Tags { get; set; }
        public virtual int Is_read { get; set; }
        public virtual DateTime? Read_dt { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual int Is_valid { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}