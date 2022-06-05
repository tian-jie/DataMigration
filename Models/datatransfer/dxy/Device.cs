using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Devices : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        // 2017-01-29 Delete Start ------>
        //public virtual int? Pid { get; set; }
        // 2017-01-29 Delete End   ------<
        public virtual int? Status { get; set; }
        public virtual string Imei { get; set; }
        // 2017-01-29 Delete Start ------>
        //public virtual string Unbinding_Reason { get; set; }
        //public virtual int? Binding_Time { get; set; }
        //public virtual int? Unbinding_Time { get; set; }
        // 2017-01-29 Delete End   ------<
        public override DateTime CreatedUtc { get; set; }
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int? Created { get; set; }
        // 2018-11-29 Add End   ------<
    }
}