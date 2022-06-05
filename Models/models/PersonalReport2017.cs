using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class PersonalReport2017 : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string HcpId { get; set; }
        public virtual string FamilyName { get; set; }
        public virtual string GivenName { get; set; }
        public virtual int EnrollDate { get; set; }
        public virtual int TotalPatient { get; set; }
        public virtual int TotalFastingTime { get; set; }
        public virtual int StandardFastingTime { get; set; }
        public virtual int TotalAfterBreakfastTime { get; set; }
        public virtual int StandardAfterBreakfastTime { get; set; }
        public virtual int TotalBeforeLunchTime { get; set; }
        public virtual int StandardBeforeLunchTime { get; set; }
        public virtual int TotalAfterLunchTime { get; set; }
        public virtual int StandardAfterLunchTime { get; set; }
        public virtual int TotalBeforeSupperTime { get; set; }
        public virtual int StandardBeforeSupperTime { get; set; }
        public virtual int TotalAfterSupperTime { get; set; }
        public virtual int StandardAfterSupperTime { get; set; }
        public virtual int TotalBedtimeTime { get; set; }
        public virtual int StandardBedtimeTime { get; set; }
        public virtual bool HasViewedReport { get; set; }
    }
}