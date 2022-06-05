using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_PatientDdcMsg_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Sid { get; set; }
        public virtual int Pid { get; set; }
        public virtual int Type { get; set; }
        public virtual int Is_read { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime? Read_dt { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual string Json { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}