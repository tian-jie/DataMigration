
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace InnoCellence.Lccp.Data.Models
{
    public class CDSTask : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int PatientId { get; set; }
        public virtual string FirstTreatmentRId { get; set; }
        public virtual bool? IsFirstTreatmentConfirmed { get; set; }
        public virtual DateTime? FirstTreatmentConfirmDate { get; set; }
        public virtual bool? IsReTreatmentConfirmed { get; set; }
        public virtual DateTime? ReTreatmentConfirmDate { get; set; }
        public virtual string ReTreatmentRId { get; set; }
        public virtual string ReTreatmentConfirmRole { get; set; }
        public virtual string OriginHcpId { get; set; }
        public virtual int? InteractionId { get; set; }
        public virtual string SessionId { get; set; }
        public virtual DateTime? InteractionDate { get; set; }
        public virtual int? InteractionId2 { get; set; }
        public virtual string SessionId2 { get; set; }
        public virtual DateTime? InteractionDate2 { get; set; }
        public virtual int? InteractionId3 { get; set; }
        public virtual string SessionId3 { get; set; }
        public virtual DateTime? InteractionDate3 { get; set; }
        public virtual int? ReferralDate { get; set; }
        public virtual DateTime? CreateTime { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsFailed { get; set; }
        public virtual int?  OverTime{get;set;}
        public virtual DateTime? OverDate { get; set; }
        public virtual int RoundFlag { get; set; }
        public virtual DateTime? RoundTime { get; set; }
    }
}