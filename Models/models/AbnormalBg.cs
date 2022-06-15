using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Core;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("abnormalbg")]
    public class AbnormalBg : EntityBase<int>
    {
        [Column("patientid")]
        public virtual int? PatientId { get; set; }
        [Column("dataguid")]
        public virtual string DataGuid { get; set; }
        [Column("time")]
        public virtual DateTime? Time { get; set; }
        [Column("value")]
        public virtual decimal? Value { get; set; }
        [Column("lowest")]
        public virtual bool? Lowest { get; set; }
        [Column("low")]
        public virtual bool? Low { get; set; }
        [Column("good1")]
        public virtual bool? Good1 { get; set; }
        [Column("good2")]
        public virtual bool? Good2 { get; set; }
        [Column("createtime")]
        public virtual DateTime? CreateTime { get; set; }
        [Column("warned")]
        public virtual bool? Warned { get; set; }

        //废弃，业务上使用BgUnWaringStack.UnWarningByBGDataGuid替代
        [Column("unwarned")]
        public virtual bool? UnWarned { get; set; }
    }
}