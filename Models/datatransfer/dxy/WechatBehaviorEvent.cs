using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_WechatBehaviorEvent : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Url { get; set; }
        public virtual int Event_datetime { get; set; }
        public virtual string Event_comment { get; set; }
        public virtual string Real_member_id { get; set; }
        public virtual int? Updated { get; set; }
        public virtual string Deleted { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-05-08 Add Start ------>
        public virtual int? Created { get; set; }
        // 2018-05-08 Add End   ------<
    }
}