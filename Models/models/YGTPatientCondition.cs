
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace InnoCellence.Lccp.Data.Models
{
    public class YGTPatientCondition : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string HcpId { get; set; }
        public virtual int PatientId { get; set; }
        public virtual DateTime? PatientEnroDate { get; set; }


        public virtual DateTime? StartEvaDate { get; set; }
        public virtual DateTime? StartCalDate { get; set; }
        public virtual DateTime? CalDateIndex { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public virtual bool? IsDeleted { get; set; }


        //switch
        //public virtual int? Amount28 { get; set; }
        //public virtual int? Amount28AfterBg { get; set; }
        //public virtual DateTime? Amount28ReachTime { get; set; }

        //public virtual decimal? AvgEmpty { get; set; }
        //public virtual DateTime? AvgEmptyReachTime { get; set; }
        //public virtual decimal? AvgAfter { get; set; }
        //public virtual DateTime? AvgAfterReachTime { get; set; }

        //public virtual int? AvgEmptyAmount { get; set; }
        //public virtual int? AvgAfterAmount { get; set; }
        public virtual decimal? AvgEmptyTarget1 { get; set; }
        public virtual decimal? AvgEmptyTarget2 { get; set; }
        public virtual decimal? AvgAfterTarget1 { get; set; }
        public virtual decimal? AvgAfterTarget2 { get; set; }

        public virtual string CreatedBy { get; set; }

        public virtual int? BloodSugarNumberBefore { get; set; }
        public virtual int? BloodSugarNumberAfter { get; set; }

    }
}