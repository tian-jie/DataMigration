using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_BgData : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int Pid { get; set; }
        public virtual string Record_Id { get; set; }
        public virtual float Record_Result { get; set; }
        public virtual string Record_time { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-09-04 Add Start ------>
        public virtual int Record_time_range { get; set; }
        public virtual int Updated { get; set; }
        // 2017-09-04 Add End   ------<
        // 2017-10-13 Add Start ------>
        public virtual int Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual string Imei { get; set; }
        public virtual int Created { get; set; }
        // 2018-11-29 Add End   ------<
    }
}