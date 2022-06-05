using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_WechatBehavior : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Agent { get; set; }
        public virtual string Cookie_Id { get; set; }
        public virtual int Gmt_Log { get; set; }
        public virtual string Device_Group { get; set; }
        public virtual string Page_Id { get; set; }
        public virtual string Real_Member_Id { get; set; }
        // 2018-03-26 Add Start ------>
        public virtual string Url { get; set; }
        // 2018-03-26 Add End   ------<
        public virtual string Real_Url { get; set; }
        public virtual int Page_Stay_Second { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-05-08 Add Start ------>
        public virtual int? Created { get; set; }
        // 2018-05-08 Add End   ------<
    }
}