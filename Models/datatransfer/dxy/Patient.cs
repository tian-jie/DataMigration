using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Patient : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal? Birthday { get; set; }
        public virtual string Phone_number { get; set; }
        public virtual string Simuid { get; set; }
        public virtual string Suitable_Contact { get; set; }
        // 2017-01-30 Delete Start ------>
        //public virtual int? Is_Insulin { get; set; }
        // 2017-01-30 Delete End   ------<
        public virtual int Is_Use_Wechat { get; set; }
        public virtual int Status { get; set; }
        public virtual int Agent_Id { get; set; }
        public virtual string Province { get; set; }
        public virtual string City { get; set; }
        public virtual string County { get; set; }
        // 2018-08-10 Add Start ------>
        public virtual int Education { get; set; }
        // 2018-08-10 Add End   ------<
        public virtual string Street { get; set; }
        public virtual Int64? Confirmed_Date { get; set; }
        public virtual int Disease_Type { get; set; }
        public virtual int? Drug_Same_Hospital { get; set; }
        public virtual int? Inject_Time { get; set; }
        public virtual int? Optiset_Type { get; set; }
        public virtual int? Use_Pattern { get; set; }
        // 2018-08-10 Add Start ------>
        public virtual int Is_first_time { get; set; }
        public virtual int Use_drug_history { get; set; }
        public virtual string Use_other_drug { get; set; }
        // 2018-08-10 Add End   ------<
        // 2018-03-26 Add Start ------>
        public virtual int Use_wechat_oneself { get; set; }
        public virtual int Is_virtual { get; set; }
        // 2018-03-26 Add End   ------<
        // 2018-03-02 Add Start ------>
        public virtual int Begin_Yml_Insulin { get; set; }
        // 2018-03-02 Add End   ------<
        public virtual int? Other_Glucometer { get; set; }
        public virtual int? Consent_Id { get; set; }
        public virtual int? Sign_Time { get; set; }
        public virtual int? Enrollment_Time { get; set; }
        public virtual int? Suspend_time { get; set; }
        public virtual string De_Enrollment_Reason { get; set; }
        public virtual int De_Enrollment_Time { get; set; }
        public virtual string Insulin_Batch_No { get; set; }
        public virtual string Last_Insulin { get; set; }
        // 2017-01-30 Delete Start ------>
        //public virtual string Insulin_Name { get; set; }
        //public virtual int? Recommend_Measuring_Frequency { get; set; }
        //public virtual string Recommend_Measuring_Period { get; set; }
        // 2017-01-30 Delete End   ------<
        public override DateTime CreatedUtc { get; set; }
        // 2017-01-30 Delete Start ------>
        //// 2017-03-28 Add Start ------>
        //public virtual int? Insulin_Start_Time { get; set; }
        //public virtual float? Dosage { get; set; }
        //// 2017-03-28 Add End   ------<
        // 2017-01-30 Delete End   ------<
        // 2017-09-06 Add Start ------>
        public virtual int? Check_date { get; set; }
        // 2017-01-30 Delete Start ------>
        //public virtual int? If_sellf_testing { get; set; }
        //public virtual string Insulin_type { get; set; }
        //public virtual int? Self_measuring_frequency { get; set; }
        //public virtual string Self_measuring_period { get; set; }
        // 2017-01-30 Delete End   ------<
        // 2017-09-06 Add End   ------<
        // 2017-10-13 Add Start ------>
        public virtual int Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2017-10-30 Add Start ------>
        public virtual int Sex { get; set; }
        // 2017-10-30 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-09-18 Add Start ------>
        public virtual int Created { get; set; }
        public virtual int Is_acceptcall { get; set; }
        public virtual int Dyz_use_insulin { get; set; }
        public virtual int Use_drug_history_none_lilly { get; set; }
        public virtual int Patient_type { get; set; }
        // 2018-09-18 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int Recommend_doctor { get; set; }
        public virtual string Treatment_hospital { get; set; }
        public virtual int Dyz_register_status { get; set; }
        public virtual string Dyz_register_info { get; set; }
        public virtual string Check_reason { get; set; }
        public virtual string Stop_drug_reason { get; set; }
        // 2018-11-29 Add End   ------<

        public virtual int Hsptl_id { get; set; }
        public virtual string Wechat_openid { get; set; }
        public virtual int Normal_user_lilly_insulin_type { get; set; }
        public virtual string Union_id { get; set; }

        public virtual string Nationality { get; set; }

        public virtual int Origin { get; set; }

        public virtual string User_type { get; set; }
        public virtual int? Is_focus_on { get; set; }
        public virtual string Nurse_id { get; set; }
        public virtual string Unionid { get; set; }
        public virtual int? Drug_use { get; set; }
    }
}