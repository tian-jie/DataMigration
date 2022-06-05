using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Pc : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Pc_complainter_if_patient { get; set; }
        public virtual string Pc_complainter_name { get; set; }
        public virtual string Pc_complainter_phone_number { get; set; }
        public virtual string Pc_complainter_country { get; set; }
        public virtual string Pc_complainter_province { get; set; }
        public virtual string Pc_complainter_city { get; set; }
        public virtual string Pc_complainter_address { get; set; }
        public virtual string Pc_complainter_sex { get; set; }
        public virtual string Pc_complainter_type { get; set; }
        public virtual string Pc_complainter_type_adtion { get; set; }
        public virtual string Pc_reporter_Id { get; set; }
        public virtual string Pc_reporter_if_internal { get; set; }
        public virtual string Pc_reporter_if_complainter { get; set; }
        public virtual string Pc_reporter_name { get; set; }
        public virtual string Pc_reporter_sex { get; set; }
        public virtual string Pc_reporter_phone_number { get; set; }
        public virtual string Pc_reporter_country { get; set; }
        public virtual string Pc_reporter_province { get; set; }
        public virtual string Pc_reporter_city { get; set; }
        public virtual string Pc_reporter_address { get; set; }
        public virtual string Pc_reporter_type_adtion { get; set; }
        public virtual string Pc_product_Id { get; set; }
        public virtual string Pc_product_product_name { get; set; }
        public virtual string Pc_product_batch_number { get; set; }
        public virtual string Pc_product_sub_batch_number { get; set; }
        // 2017-05-16 Edit [int change string] Start ------>
        public virtual string Pc_product_count { get; set; }
        // 2017-05-16 Edit [int change string] End   ------<
        public virtual string Pc_product_production_date { get; set; }
        public virtual string Pc_product_valid_period { get; set; }
        public virtual string Pc_product_regulatory_code { get; set; }
        public virtual string Pc_product_bug_address { get; set; }
        public virtual string Pc_product_standard { get; set; }
        public virtual string Pc_product_product_code { get; set; }
        public virtual string Pc_product_formulations { get; set; }
        public virtual string Pc_product_manufacturer { get; set; }
        public virtual string Pc_product_description { get; set; }
        public virtual string Pc_event_report_status { get; set; }
        public virtual string Pc_event_report_time { get; set; }
        public virtual string Pc_event_start_time { get; set; }
        public virtual string Pc_event_end_time { get; set; }
        public virtual string Pc_create_time { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-03-28 Add Start ------>
        public virtual string Pc_event_report_source { get; set; }
        // 2017-03-28 Add End   ------<
        // 2017-09-06 Add Start ------>
        public virtual string Pc_reporter_type { get; set; }
        public virtual string Pc_event_id { get; set; }
        // 2017-09-06 Add End   ------<
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
    }
}