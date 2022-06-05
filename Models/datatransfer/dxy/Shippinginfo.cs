using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Shippinginfo : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int Pid { get; set; }
        public virtual string Goods { get; set; }
        public virtual string Province { get; set; }
        public virtual string City { get; set; }
        public virtual string County { get; set; }
        public virtual int? Delivery_Time { get; set; }
        public virtual int? Receiving_Time { get; set; }
        public virtual string Street { get; set; }
        public virtual int Goods_Number { get; set; }
        public virtual string Imei { get; set; }
        public virtual string Express_Number { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-10-13 Add Start ------>
        public virtual int Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int Shipping_status { get; set; }
        public virtual int Created { get; set; }
        // 2018-11-29 Add End   ------<
    }
}