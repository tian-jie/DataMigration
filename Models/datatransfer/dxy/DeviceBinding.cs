using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_DeviceBinding : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int? Pid { get; set; }
        public virtual string Imei { get; set; }
        public virtual string Unbinding_Reason { get; set; }
        public virtual int? Binding_Time { get; set; }
        public virtual int? Unbinding_Time { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public virtual string Deleted { get; set; }
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
    }
}