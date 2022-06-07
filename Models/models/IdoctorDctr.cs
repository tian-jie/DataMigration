using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("idoctordctr")]
    public class IdoctorDctr : EntityBase<int>
    {
        [Column("id")]
        public override int Id { get; set; }
        [Column("dctrid")]
        public virtual decimal DctrId { get; set; }
        [Column("openid")]
        public virtual string OpenId { get; set; }
        [Column("projecthcpid")]
        public virtual string ProjectHcpId { get; set; }
        [Column("familyname")]
        public virtual string FamilyName { get; set; }
        [Column("givenname")]
        public virtual string GivenName { get; set; }
        [Column("gender")]
        public virtual decimal? Gender { get; set; }
        [Column("cityid")]
        public virtual decimal? CityId { get; set; }
        [Column("hsptlid")]
        public virtual decimal? HsptlId { get; set; }
        [Column("clinician")]
        public virtual decimal? Clinician { get; set; }
        [Column("deptname")]
        public virtual string DeptName { get; set; }
        [Column("acadtitle")]
        public virtual string AcadTitle { get; set; }
        [Column("proftitle")]
        public virtual string ProfTitle { get; set; }
        [Column("cityname")]
        public virtual string CityName { get; set; }
        [Column("cstmrname")]
        public virtual string CstmrName { get; set; }
        [Column("email")]
        public virtual string Email { get; set; }
        [Column("wechatsalesrepid")]
        public virtual string WechatSalesRepId { get; set; }
        [Column("provincename")]
        public virtual string ProvinceName { get; set; }
        [Column("provinceid")]
        public virtual int? ProvinceId { get; set; }
        [Column("isdeleted")]
        public virtual bool Isdeleted { get; set; }
        [Column("createdutc")]
        public virtual DateTime? Createdutc { get; set; }
        [Column("modifiedutc")]
        public virtual DateTime? Modifiedutc { get; set; }
        [Column("ispushweeklybgreport")]
        public virtual bool? IsPushWeeklyBgReport { get; set; }
        [Column("ispushwhennewcardjoin")]
        public virtual bool? IsPushWhenNewCardJoin { get; set; }
        [Column("ispushwhenpatientjoin")]
        public virtual bool? IsPushWhenPatientJoin { get; set; }
        [Column("phone")]
        public virtual string Phone { get; set; }
        [Column("lccpphone")]
        public virtual string LccpPhone { get; set; }
        [Column("lillyid")]
        public virtual string LillyId { get; set; }
        [Column("lillyrole")]
        public virtual string LillyRole { get; set; }
        [Column("enrolldate")]
        public virtual DateTime? EnrollDate { get; set; }
        [Column("wechatsalesrepid_trtry_id")]
        public virtual decimal? WechatSalesRepId_TRTRY_ID { get; set; }
        [Column("wechatsalesrepid_trtry_cd")]
        public virtual string WechatSalesRepId_TRTRY_CD { get; set; }
        [Column("rgnname")]
        public virtual string RgnName { get; set; }
        // 2018-01-08 Add Start ------>
        [Column("isreport")]
        public virtual bool IsReport { get; set; }
        // 2018-01-08 Add End   ------<
        //2018-04-24 Add Start ------>
        [Column("firstlogintime")]
        public virtual DateTime? FirstLoginTime { get; set; }
        [Column("ispushpatientbgwarning")]
        public virtual bool? IsPushPatientBgWarning { get; set; }
        //2018-04-24 Add End   ------<
        [Column("isidoctorsuccess")]
        public virtual bool? IsIDoctorSuccess { get; set; }
        [Column("isdxysuccess")]
        public virtual bool? IsDxySuccess { get; set; }
        [Column("unionid")]
        public virtual string UnionId { get; set; }
        // 2018-05-10 Add Start ------>
        [Column("ispocketdoctor")]
        public virtual bool IsPocketDoctor { get; set; }
        // 2018-05-10 Add End   ------<
        [Column("pocketenrolldate")]
        public virtual DateTime? PocketEnrollDate { get; set; }

        [Column("isdummy")]
        public virtual bool? IsDummy { get; set; }
        [Column("iscds")]
        public virtual bool? IsCDS { get; set; }
        [Column("cdsenrolldate")]
        public virtual DateTime? CDSEnrollDate { get; set; }

        [Column("ispushwhenpatientfeedback")]
        public virtual bool? IsPushWhenPatientFeedback { get; set; }
        [Column("isygt")]
        public virtual bool? IsYGT { get; set; }
        [Column("ygtenrolldate")]
        public virtual DateTime? YGTEnrollDate { get; set; }

        [Column("isttq")]
        public virtual bool? IsTTQ { get; set; }
        [Column("ttqenrolldate")]
        public virtual DateTime? TTQEnrollDate { get; set; }

    }
}