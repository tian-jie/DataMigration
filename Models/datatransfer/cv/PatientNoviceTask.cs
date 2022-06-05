using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_PatientNoviceTask_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Pid { get; set; }
        public virtual DateTime Start_dt { get; set; }
        public virtual DateTime End_dt { get; set; }
        public virtual int Status { get; set; }
        public virtual int Ques_task { get; set; }
        public virtual int File_task { get; set; }
        public virtual int Course_task { get; set; }
        public virtual int Sugar_task { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}