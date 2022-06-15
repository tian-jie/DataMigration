using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_ae")]
    public class Lilly_DXY_Data_Ae : DxyEntityBase<int>
    {
        [Column("ae_reporter_name")]
        public virtual string Ae_reporter_name { get; set; }
        [Column("ae_reporter_phone_number")]
        public virtual string Ae_reporter_phone_number { get; set; }
        [Column("ae_reporter_address")]
        public virtual string Ae_reporter_address { get; set; }
        [Column("ae_reporter_type")]
        public virtual string Ae_reporter_type { get; set; }
        [Column("ae_reporter_tepe_addition")]
        public virtual string Ae_reporter_tepe_addition { get; set; }
        [Column("ae_doctor_name")]
        public virtual string Ae_doctor_name { get; set; }
        [Column("ae_doctor_phone_number")]
        public virtual string Ae_doctor_phone_number { get; set; }
        [Column("ae_doctor_department")]
        public virtual string Ae_doctor_department { get; set; }
        [Column("ae_patient_name")]
        public virtual string Ae_patient_name { get; set; }
        [Column("ae_patient_phone_number")]
        public virtual string Ae_patient_phone_number { get; set; }
        [Column("ae_patient_birthday")]
        public virtual string Ae_patient_birthday { get; set; }
        [Column("ae_patient_sex")]
        public virtual int? Ae_patient_sex { get; set; }
        [Column("ae_patient_age")]
        public virtual int? Ae_patient_age { get; set; }
        [Column("ae_patient_height")]
        public virtual string Ae_patient_height { get; set; }
        [Column("ae_patient_weight")]
        public virtual string Ae_patient_weight { get; set; }
        [Column("ae_patient_nation")]
        public virtual string Ae_patient_nation { get; set; }
        [Column("ae_patient_case_histroy")]
        public virtual string Ae_patient_case_histroy { get; set; }
        [Column("ae_patient_drug_reaction")]
        public virtual int? Ae_patient_drug_reaction { get; set; }
        [Column("ae_patient_drug_reaction_detail")]
        public virtual string Ae_patient_drug_reaction_detail { get; set; }
        [Column("ae_patient_family_reaction")]
        public virtual int? Ae_patient_family_reaction { get; set; }
        [Column("ae_patient_family_reaction_detail")]
        public virtual string Ae_patient_family_reaction_detail { get; set; }
        [Column("ae_event_id")]
        public virtual int? Ae_event_ID { get; set; }
        [Column("ae_event_description")]
        public virtual string Ae_event_description { get; set; }
        [Column("ae_event_result")]
        public virtual int? Ae_event_result { get; set; }
        [Column("ae_event_recult_adtion")]
        public virtual string Ae_event_recult_adtion { get; set; }
        [Column("ae_event_death_cause")]
        public virtual string Ae_event_death_cause { get; set; }
        [Column("ae_event_death_date")]
        public virtual int? Ae_event_death_date { get; set; }
        [Column("ae_event_medication_adjustment")]
        public virtual string Ae_event_medication_adjustment { get; set; }
        [Column("ae_event_medication_adjustment_addition")]
        public virtual string Ae_event_medication_adjustment_addition { get; set; }
        [Column("ae_event_if_improve")]
        public virtual string Ae_event_if_improve { get; set; }
        [Column("ae_event_if_reappear")]
        public virtual string Ae_event_if_reappear { get; set; }
        [Column("ae_event_correlation")]
        public virtual string Ae_event_correlation { get; set; }
        [Column("ae_event_if_accept_follow")]
        public virtual int? Ae_event_if_accept_follow { get; set; }
        [Column("ae_event_recorder")]
        public virtual string Ae_event_recorder { get; set; }
        [Column("ae_event_report_status")]
        public virtual int? Ae_event_report_status { get; set; }
        [Column("ae_event_report_time")]
        public virtual int? Ae_event_report_time { get; set; }
        [Column("ae_event_report_source")]
        public virtual int? Ae_event_report_source { get; set; }
        [Column("ae_event_informed_time")]
        public virtual int? Ae_event_informed_time { get; set; }
        [Column("ae_event_start_time")]
        public virtual string Ae_event_start_time { get; set; }
        [Column("ae_event_end_time")]
        public virtual string Ae_event_end_time { get; set; }
        [Column("ae_event_number")]
        public virtual string Ae_event_number { get; set; }
        [Column("ae_event_type")]
        public virtual string Ae_event_type { get; set; }
        [Column("ae_prev_event_id")]
        public virtual string Ae_prev_event_id { get; set; }
        [Column("ae_create_time")]
        public virtual int Ae_create_time { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
    }
}