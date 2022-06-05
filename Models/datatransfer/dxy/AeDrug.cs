using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_AeDrug : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Ae_id { get; set; }
        public virtual int? Ae_product_type { get; set; }
        public virtual string Ae_product_product_name { get; set; }
        public virtual string Ae_product_manufacturer { get; set; }
        public virtual string Ae_product_indication { get; set; }
        public virtual string Ae_product_batch_number { get; set; }
        public virtual string Ae_product_formulations { get; set; }
        public virtual string Ae_product_dose { get; set; }
        public virtual string Ae_product_usage_frequency { get; set; }
        public virtual string Ae_product_obtain_way { get; set; }
        public virtual string Ae_product_start_time { get; set; }
        public virtual string Ae_product_end_time { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public virtual string Deleted { get; set; }
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
    }
}