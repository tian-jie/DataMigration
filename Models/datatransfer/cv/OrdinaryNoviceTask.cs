using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_OrdinaryNoviceTask_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Pid { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime Updated { get; set; }
        //public virtual DateTime Insert_dt { get; set; }
        //public virtual DateTime Modify_dt { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Start_dt { get; set; }
        public virtual DateTime End_dt { get; set; }
        public virtual int Status { get; set; }
        public virtual int Ques_task { get; set; }
        public virtual DateTime Ques_task_end_dt { get; set; }
        public virtual int Add_file_task { get; set; }
        public virtual DateTime Add_file_task_end_dt { get; set; }
        public virtual int Course_task { get; set; }
        public virtual DateTime Course_task_end_dt { get; set; }
        public virtual int Update_file_task { get; set; }
        public virtual DateTime Update_file_task_start_dt { get; set; }

        public virtual int Course_task_count { get; set; }
        public virtual int Ques_task_count { get; set; }
        public virtual DateTime? Ques_finish { get; set; }
        public virtual DateTime? Course_finish { get; set; }
        public virtual DateTime? Addfile_finish { get; set; }
        public virtual DateTime? Updatefile_finish { get; set; }

        public virtual int Insulin_task { get; set; }
        public virtual DateTime? Insulin_finish { get; set; }
        public virtual DateTime Insulin_task_end_dt { get; set; }

        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}