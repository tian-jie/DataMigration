using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Ae : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Ae_reporter_name { get; set; }
        public virtual string Ae_reporter_phone_number { get; set; }
        public virtual string Ae_reporter_address { get; set; }
        public virtual string Ae_reporter_type { get; set; }
        public virtual string Ae_reporter_tepe_addition { get; set; }
        public virtual string Ae_doctor_name { get; set; }
        public virtual string Ae_doctor_phone_number { get; set; }
        public virtual string Ae_doctor_department { get; set; }
        public virtual string Ae_patient_name { get; set; }
        public virtual string Ae_patient_phone_number { get; set; }
        public virtual string Ae_patient_birthday { get; set; }
        public virtual int? Ae_patient_sex { get; set; }
        public virtual int? Ae_patient_age { get; set; }
        // 2017-05-16 Edit [int change string] Start ------>
        public virtual string Ae_patient_height { get; set; }
        public virtual string Ae_patient_weight { get; set; }
        // 2017-05-16 Edit [int change string] End   ------<
        public virtual string Ae_patient_nation { get; set; }
        public virtual string Ae_patient_case_histroy { get; set; }
        public virtual int? Ae_patient_drug_reaction { get; set; }
        public virtual string Ae_patient_drug_reaction_detail { get; set; }
        public virtual int? Ae_patient_family_reaction { get; set; }
        public virtual string Ae_patient_family_reaction_detail { get; set; }
        // 2017-01-29 Delete Start ------>
        //public virtual int? Ae_product_type { get; set; }
        //public virtual string Ae_product_product_name { get; set; }
        //public virtual string Ae_product_manufacturer { get; set; }
        //public virtual string Ae_product_indication { get; set; }
        //public virtual string Ae_product_batch_number { get; set; }
        //public virtual string Ae_product_formulations { get; set; }
        //public virtual string Ae_product_dose { get; set; }
        //public virtual string Ae_product_usage_frequency { get; set; }
        //public virtual string Ae_product_obtain_way { get; set; }
        //// 2017-05-16 Edit [int change string] Start ------>
        //public virtual string Ae_product_start_time { get; set; }
        //public virtual string Ae_product_end_time { get; set; }
        //// 2017-05-16 Edit [int change string] End   ------<
        // 2017-01-29 Delete End   ------<
        public virtual int? Ae_event_ID { get; set; }
        public virtual string Ae_event_description { get; set; }
        public virtual int? Ae_event_result { get; set; }
        public virtual string Ae_event_recult_adtion { get; set; }
        public virtual string Ae_event_death_cause { get; set; }
        public virtual int? Ae_event_death_date { get; set; }
        public virtual string Ae_event_medication_adjustment { get; set; }
        public virtual string Ae_event_medication_adjustment_addition { get; set; }
        public virtual string Ae_event_if_improve { get; set; }
        public virtual string Ae_event_if_reappear { get; set; }
        public virtual string Ae_event_correlation { get; set; }
        public virtual int? Ae_event_if_accept_follow { get; set; }
        public virtual string Ae_event_recorder { get; set; }
        public virtual int? Ae_event_report_status { get; set; }
        public virtual int? Ae_event_report_time { get; set; }
        // 2017-03-28 Add Start ------>
        public virtual int? Ae_event_report_source { get; set; }
        // 2017-03-28 Add End   ------<
        // 2017-12-05 Add Start ------>
        public virtual int? Ae_event_informed_time { get; set; }
        // 2017-12-05 Add End   ------<
        // 2017-05-16 Edit [int change string] Start ------>
        public virtual string Ae_event_start_time { get; set; }
        public virtual string Ae_event_end_time { get; set; }
        // 2017-05-16 Edit [int change string] End   ------<
        public virtual string Ae_event_number { get; set; }
        public virtual string Ae_event_type { get; set; }
        public virtual string Ae_prev_event_id { get; set; }
        public virtual int Ae_create_time { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-14 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-14 Add End   ------<
    }
}