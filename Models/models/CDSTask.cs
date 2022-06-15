
using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

// TODO: 没有迁移完成，不迁移了，代码也没写完
namespace InnoCellence.Lccp.Data.Models
{
    [Table("cdstask")]
    public class CDSTask : EntityBase<int>
    {
        [Column("patientid")]
        public virtual int PatientId { get; set; }
        [Column("firsttreatmentrid")]
        public virtual string FirstTreatmentRId { get; set; }
        [Column("isfirsttreatmentconfirmed")]
        public virtual bool? IsFirstTreatmentConfirmed { get; set; }
        [Column("firsttreatmentconfirmdate")]
        public virtual DateTime? FirstTreatmentConfirmDate { get; set; }
        [Column("isretreatmentconfirmed")]
        public virtual bool? IsReTreatmentConfirmed { get; set; }
        [Column("retreatmentconfirmdate")]
        public virtual DateTime? ReTreatmentConfirmDate { get; set; }
        [Column("retreatmentrid")]
        public virtual string ReTreatmentRId { get; set; }
        [Column("patientid")]
        public virtual string ReTreatmentConfirmRole { get; set; }
        [Column("patientid")]
        public virtual string OriginHcpId { get; set; }
        [Column("patientid")]
        public virtual int? InteractionId { get; set; }
        [Column("patientid")]
        public virtual string SessionId { get; set; }
        [Column("patientid")]
        public virtual DateTime? InteractionDate { get; set; }
        [Column("patientid")]
        public virtual int? InteractionId2 { get; set; }
        [Column("patientid")]
        public virtual string SessionId2 { get; set; }
        [Column("patientid")]
        public virtual DateTime? InteractionDate2 { get; set; }
        [Column("patientid")]
        public virtual int? InteractionId3 { get; set; }
        [Column("patientid")]
        public virtual string SessionId3 { get; set; }
        [Column("patientid")]
        public virtual DateTime? InteractionDate3 { get; set; }
        [Column("patientid")]
        public virtual int? ReferralDate { get; set; }
        [Column("patientid")]
        public virtual DateTime? CreateTime { get; set; }
        [Column("patientid")]
        public virtual bool IsDeleted { get; set; }
        [Column("patientid")]
        public virtual bool IsFailed { get; set; }
        [Column("patientid")]
        public virtual int?  OverTime{get;set;}
        [Column("patientid")]
        public virtual DateTime? OverDate { get; set; }
        [Column("patientid")]
        public virtual int RoundFlag { get; set; }
        [Column("patientid")]
        public virtual DateTime? RoundTime { get; set; }
    }
}