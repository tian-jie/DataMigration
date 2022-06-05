using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class IdoctorDctr : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual decimal DctrId { get; set; }
        public virtual string OpenId { get; set; }
        public virtual string ProjectHcpId { get; set; }
        public virtual string FamilyName { get; set; }
        public virtual string GivenName { get; set; }
        public virtual decimal? Gender { get; set; }
        public virtual decimal? CityId { get; set; }
        public virtual decimal? HsptlId { get; set; }
        public virtual decimal? Clinician { get; set; }
        public virtual string DeptName { get; set; }
        public virtual string AcadTitle { get; set; }
        public virtual string ProfTitle { get; set; }
        public virtual string CityName { get; set; }
        public virtual string CstmrName { get; set; }
        public virtual string Email { get; set; }
        public virtual string WechatSalesRepId { get; set; }
        public virtual string ProvinceName { get; set; }
        public virtual int? ProvinceId { get; set; }
        public virtual bool Isdeleted { get; set; }
        public virtual DateTime? Createdutc { get; set; }
        public virtual DateTime? Modifiedutc { get; set; }
        public virtual bool? IsPushWeeklyBgReport { get; set; }
        public virtual bool? IsPushWhenNewCardJoin { get; set; }
        public virtual bool? IsPushWhenPatientJoin { get; set; }
        public virtual string Phone { get; set; }
        public virtual string LccpPhone { get; set; }
        public virtual string LillyId { get; set; }
        public virtual string LillyRole { get; set; }
        public virtual DateTime? EnrollDate { get; set; }
        public virtual decimal? WechatSalesRepId_TRTRY_ID { get; set; }
        public virtual string WechatSalesRepId_TRTRY_CD { get; set; }
        public virtual string RgnName { get; set; }
        // 2018-01-08 Add Start ------>
        public virtual bool IsReport { get; set; }
        // 2018-01-08 Add End   ------<
        //2018-04-24 Add Start ------>
        public virtual DateTime? FirstLoginTime { get; set; }
        public virtual bool? IsPushPatientBgWarning { get; set; }
        //2018-04-24 Add End   ------<
        public virtual bool? IsIDoctorSuccess { get; set; }
        public virtual bool? IsDxySuccess { get; set; }
        public virtual string UnionId { get; set; }
        // 2018-05-10 Add Start ------>
        public virtual bool IsPocketDoctor { get; set; }
        // 2018-05-10 Add End   ------<
        public virtual DateTime? PocketEnrollDate { get; set; }

        public virtual bool? IsDummy { get; set; }
        public virtual bool? IsCDS { get; set; }
        public virtual DateTime? CDSEnrollDate { get; set; }

        public virtual bool? IsPushWhenPatientFeedback { get; set; }
        public virtual bool? IsYGT { get; set; }
        public virtual DateTime? YGTEnrollDate { get; set; }

        public virtual bool? IsTTQ { get; set; }
        public virtual DateTime? TTQEnrollDate { get; set; }

    }
}