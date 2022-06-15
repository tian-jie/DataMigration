
using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace InnoCellence.Lccp.Data.Models
{
    [Table("card")]
    public class Card : EntityBase<int>
    {
        [Column("dctrid")]
        public virtual decimal? DctrId { get; set; }
        [Column("projecthcpid")]
        public virtual string ProjectHcpId { get; set; }
        [Column("salesrepid")]
        public virtual string SalesRepId { get; set; }
        [Column("cardnumber")]
        public virtual string CardNumber { get; set; }
        [Column("patientcardnumber")]
        public virtual string PatientCardNumber { get; set; }
        [Column("enrolldate")]
        public virtual DateTime? EnrollDate { get; set; }
        [Column("versionnumber")]
        public virtual int? VersionNumber { get; set; }
        [Column("ownerid")]
        public virtual int? OwnerId { get; set; }
        [Column("createdutc")]
        public virtual DateTime? CreatedUtc { get; set; }
        [Column("modifiedid")]
        public virtual int? ModifiedId { get; set; }
        [Column("modifiedutc")]
        public virtual DateTime? ModifiedUtc { get; set; }
        [Column("isdeleted")]
        public virtual bool IsDeleted { get; set; }

        //LCCP
        [Column("patientid")]
        public virtual int? PatientId { get; set; }
        [Column("patientbindingtime")]
        public virtual DateTime? PatientBindingTime { get; set; }
        [Column("registedtime")]
        public virtual DateTime? RegistedTime { get; set; }
        // 2017/06/23 Add Start ------>
        [Column("islock")]
        public virtual string IsLock { get; set; }
        [Column("isuse")]
        public virtual string IsUse { get; set; }
        [Column("isvirtualcard")]
        public virtual string IsVirtualCard { get; set; }
        [Column("applytime")]
        public virtual DateTime? ApplyTime { get; set; }
        [Column("patientopenid")]
        public virtual string PatientOpenId { get; set; }
        // 2017/06/23 Add End   ------<

        // 2018/05/09 Add Start ------>
        [Column("isstar")]
        public virtual bool? IsStar { get; set; }
        // 2018/05/09 Add End   ------<

        [Column("patientstatus")]
        public virtual int PatientStatus { get; set; }
        [Column("islatest")]
        public virtual int IsLatest { get; set; }
    }
}