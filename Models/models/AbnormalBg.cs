using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Core;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class AbnormalBg : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int? PatientId { get; set; }
        public virtual string DataGuid { get; set; }
        public virtual DateTime? Time { get; set; }
        public virtual decimal? Value { get; set; }
        public virtual bool? Lowest { get; set; }
        public virtual bool? Low { get; set; }
        public virtual bool? Good1 { get; set; }
        public virtual bool? Good2 { get; set; }
        public virtual DateTime? CreateTime { get; set; }
        public virtual bool? Warned { get; set; }

        //废弃，业务上使用BgUnWaringStack.UnWarningByBGDataGuid替代
        public virtual bool? UnWarned { get; set; }
    }
}