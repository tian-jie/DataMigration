using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_MedicalOrder : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int? Pid { get; set; }
        public virtual int? If_Self_Testing { get; set; }
        public virtual int? Recommend_Measuring_Frequency { get; set; }
        public virtual string Recommend_Measuring_Period { get; set; }
        public virtual int? Self_Measuring_Frequency { get; set; }
        public virtual string Self_Measuring_Period { get; set; }
        public virtual string Deleted { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-12-08 Add Start ------>
        public virtual int? Insulin_Start_Time { get; set; }
        // 2017-12-08 Add End   ------<
        // 2017-12-26 Add Start ------>
        public virtual int? Status { get; set; }
        // 2017-12-26 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
    }
}