using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class Lilly_DXY_Data_Treatments : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int Rid { get; set; }
        public virtual int? Pid { get; set; }
        public virtual int? Height { get; set; }
        public virtual int? Weight { get; set; }
        public virtual int? Scheme { get; set; }
        public virtual string Is_oral_medicine { get; set; }
        public virtual int? Week_total_number { get; set; }
        public virtual int? Use_lilly_insulin { get; set; }
        public virtual int? Day_before_number { get; set; }
        public virtual string Hba1c { get; set; }
        public virtual int? Before_breakfast { get; set; }
        public virtual int? Before_lunch { get; set; }
        public virtual int? Before_dinner { get; set; }
        public virtual int? Before_sleep { get; set; }
        public virtual int? Day_amounts { get; set; }
        // 2018-03-02 Add Start ------>
        public virtual int? Is_first_time { get; set; }
        public virtual int? Use_drug_history { get; set; }
        public virtual string Use_other_drug { get; set; }
        // 2018-03-02 Add End   ------<
        public virtual int? Status { get; set; }
        public virtual int? Created { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        // 2017-10-13 Add Start ------>
        public virtual int? Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public virtual DateTime? UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<

        //2018-08-07 Add Start
        public virtual string Medicine_name_type { get; set; }
        public virtual int? Stop_drug_reason { get; set; }
        public virtual int? Has_complications { get; set; }
        public virtual string Complications { get; set; }
        public virtual int? Systolic_blood_pressure { get; set; }
        public virtual int? Diastolic_blood_pressure { get; set; }
        public virtual string Cholesterol { get; set; }
        public virtual string High_cholesterol { get; set; }
        public virtual string Triglycerides { get; set; }
        public virtual string Low_cholesterol { get; set; }
        public virtual int? Is_join { get; set; }
        public virtual int? Is_confirm { get; set; }
        public virtual int? Source { get; set; }
        public virtual int? Referral_date { get; set; }
        //2018-08-07 Add End

        public virtual int? Has_hyperpiesis { get; set; }
        public virtual int? Has_hyperlipemia { get; set; }
        public virtual int? Blood_sugar_number_before { get; set; }
        public virtual int? Blood_sugar_number_after { get; set; }
        public virtual string Blood_sugar_value_before { get; set; }
        public virtual string Blood_sugar_value_bfml { get; set; }
        public virtual string Blood_sugar_value_after { get; set; }
        public virtual string Blood_sugar_value_bfsl { get; set; }
        public virtual string Latest_fbg { get; set; }
        public virtual int? Education { get; set; }
        public virtual string Insulin { get; set; }
        public virtual int? Is_injection_changed { get; set; }




    }
}