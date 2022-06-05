
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace InnoCellence.Lccp.Data.Models
{
    public class YGTRecord : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual decimal? DoctorId { get; set; }
        public virtual string HcpId { get; set; }
        public virtual int? PatientId { get; set; }
        public virtual DateTime? PatientEnroDate { get; set; }
        public virtual DateTime? TreatmentConfirmDate { get; set; }
        public virtual bool IsConfirmOverDate { get; set; }
        public virtual string Interaction1 { get; set; }
        public virtual string Interaction1Type { get; set; }
        
        public virtual DateTime? Interaction1Date { get; set; }
        public virtual string Interaction2 { get; set; }
        public virtual string Interaction2Type { get; set; }
        public virtual DateTime? Interaction2Date { get; set; }
        public virtual bool IsReach { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual bool IsClosed { get; set; }
        public virtual int? TaskThreeStatus { get; set; }
        public virtual DateTime? TaskThreeDate { get; set; }
        public virtual string Treatment1Id { get; set; }
        public virtual string Treatment3Id { get; set; }
        public virtual DateTime? TaskTwoOverTimeDate { get; set; }
        public virtual bool IsTaskTwoOverTime { get; set; }
        public virtual decimal? AvgEmptyValue { get; set; }
        public virtual int? AvgEmptyAmount { get; set; }
        public virtual DateTime? AvgEmptyValueReachTime { get; set; }
        public virtual decimal? AvgAfterValue { get; set; }
        public virtual int? AvgAfterAmount { get; set; }
        public virtual DateTime? AvgAfterValueReachTime { get; set; }
        public virtual decimal? BloodSugarNumberBefore28 { get; set; }
        public virtual decimal? BloodSugarNumberAfter28 { get; set; }
        public virtual DateTime? BloodSugarNumber28ReachTime { get; set; }
        public virtual int? Amount28 { get; set; }
    }
}