using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_CourseRemind_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Pid { get; set; }
        public virtual int? Is_open { get; set; }
        public virtual string Remind_time { get; set; }
        public virtual int Monday { get; set; }
        public virtual int Tuesday { get; set; }
        public virtual int Wednesday { get; set; }
        public virtual int Thursday { get; set; }
        public virtual int Friday { get; set; }
        public virtual int Saturday { get; set; }
        public virtual int Sunday { get; set; }
        public virtual int Is_finish { get; set; }
        public virtual int? Remind_num { get; set; }
        public virtual DateTime? Last_study_date { get; set; }
        public virtual int? Study_status { get; set; }
        public virtual int Courser_remind { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}