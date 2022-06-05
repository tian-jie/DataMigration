using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class ReferralDateHistory : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int? ReferralDate { get; set; }
        public virtual int? PatientId { get; set; }
        public virtual int? TreatmentCreateTime { get; set; }        
        public virtual DateTime? CreateTime { get; set; }
        public virtual int? TreatmentId { get; set; }
        public virtual string From { get; set; }
    }
}