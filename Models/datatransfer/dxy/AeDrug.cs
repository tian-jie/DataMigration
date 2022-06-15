using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_aedrug")]
    public class Lilly_DXY_Data_AeDrug : DxyEntityBase<int>
    {
        [Column("ae_id")]
        public virtual string Ae_id { get; set; }
        [Column("ae_product_type")]
        public virtual int? Ae_product_type { get; set; }
        [Column("ae_product_product_name")]
        public virtual string Ae_product_product_name { get; set; }
        [Column("ae_product_manufacturer")]
        public virtual string Ae_product_manufacturer { get; set; }
        [Column("ae_product_indication")]
        public virtual string Ae_product_indication { get; set; }
        [Column("ae_product_batch_number")]
        public virtual string Ae_product_batch_number { get; set; }
        [Column("ae_product_formulations")]
        public virtual string Ae_product_formulations { get; set; }
        [Column("ae_product_dose")]
        public virtual string Ae_product_dose { get; set; }
        [Column("ae_product_usage_frequency")]
        public virtual string Ae_product_usage_frequency { get; set; }
        [Column("ae_product_obtain_way")]
        public virtual string Ae_product_obtain_way { get; set; }
        [Column("ae_product_start_time")]
        public virtual string Ae_product_start_time { get; set; }
        [Column("ae_product_end_time")]
        public virtual string Ae_product_end_time { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
    }
}