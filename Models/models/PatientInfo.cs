
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class PatientInfo : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int? PatientId { get; set; }
        public virtual string Province { get; set; }
        public virtual string OpenId { get; set; }
        public virtual string UnionId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Birthday { get; set; }
        public virtual int? Gender { get; set; }
        public virtual decimal? Height { get; set; }
        public virtual decimal? Weight { get; set; }
        public virtual decimal? BMI { get; set; }
        public virtual DateTime? FirstDiagnoseDate { get; set; }
        public virtual DateTime? FirstUseInsulinDate { get; set; }
        public virtual string UserType { get; set; }
        public virtual string Treatment { get; set; }
        public virtual decimal? MetabolizeValue { get; set; }
        public virtual string Complication { get; set; }
        public virtual int? SuggestedTestFrequency { get; set; }
        public virtual int? VersionNumber { get; set; }        
        public virtual int? OwnerId { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual int? ModifiedId { get; set; }
        public virtual DateTime? ModifiedUtc { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual string SuggestedTestFrequencyPeriod { get; set; }
        public virtual string Status { get; set; }
        // 2017-11-13 Add Start ------>
        public virtual string Avatar { get; set; }
        public virtual string City { get; set; }
        // 2017-11-13 Add End   ------<
        public virtual bool? IsTestFrequencyReachSuggested { get; set; }
        public virtual string Enrollment_Time { get; set; }
        public virtual DateTime? EnrollmentTime { get; set; }
        public virtual DateTime? DeEnrollmentTime { get; set; }
        public virtual string InsulinName { get; set; }
        public virtual int? DiseaseType { get; set; }
        public virtual bool? IsLilly { get; set; }
        public virtual int? Patienttype { get; set; }
        public virtual bool? IsVirtual { get; set; }

        public virtual int Origin { get; set; }
    }
}