using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_PatientChapter_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Pid { get; set; }
        public virtual Int64 Course_id { get; set; }
        public virtual Int64 Chapter_id { get; set; }
        public virtual int Status { get; set; }
        public virtual int? Score { get; set; }
        public virtual string Answer_json { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}