using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Hcp : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Name { get; set; }
        public virtual int? Status { get; set; }
        public virtual string HcpId { get; set; }
        public virtual int? Consent_Id { get; set; }
        public virtual int? Signed_Time { get; set; }
        public virtual int? Enrollment_Time { get; set; }
        public virtual int? De_Enrollment_Time { get; set; }
        public virtual string De_Enrollment_Reason { get; set; }
        // 2017-01-29 Delete Start ------>
        //public virtual int? Reminder_Option { get; set; }
        // 2017-01-29 Delete End   ------<
        public override DateTime CreatedUtc { get; set; }
        // 2017-09-05 Add Start ------>
        public virtual int? Hospital_id { get; set; }
        public virtual string Hospital_name { get; set; }
        public virtual int? City_id { get; set; }
        public virtual string City_name { get; set; }
        public virtual int? Province_id { get; set; }
        public virtual string Province_name { get; set; }
        // 2017-09-05 Add End   ------<
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int? Created { get; set; }
        public virtual int? IsDummyDoctor { get; set; }
        public virtual string RgnName { get; set; }
        // 2018-11-29 Add End   ------<
    }
}