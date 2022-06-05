using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_BgmBehavior : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        // 2018-04-08 Add Start ------>
        public virtual Int64 Req_Id { get; set; }
        // 2018-04-08 Add End   ------<
        public virtual string Imei { get; set; }
        public virtual string  Cmd { get; set; }
        public virtual string Value { get; set; }
        public virtual string Version_Name { get; set; }
        public virtual string Version_Code { get; set; }
        public virtual string Time { get; set; }
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