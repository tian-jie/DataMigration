using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_CallRecords : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int? Pid { get; set; }
        public virtual int? Call_Type { get; set; }
        public virtual int? StartTime { get; set; }
        public virtual int? EndTime { get; set; }
        public virtual int? Contact_Object { get; set; }
        // 2017-01-29 Delete Start ------>
        //public virtual string Call_Reason { get; set; }
        // 2017-01-29 Delete End   ------<
        public virtual string Remark { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-09-05 Add Start ------>
        // 2017-01-29 Delete Start ------>
        //public virtual string Title { get; set; }
        // 2017-01-29 Delete End   ------<
        public virtual string Result { get; set; }
        // 2017-09-05 Add End   ------<
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2017-12-15 Add Start ------>
        public virtual int? Event_id { get; set; }
        // 2017-12-15 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int? Created { get; set; }
        // 2018-11-29 Add End   ------<
    }
}