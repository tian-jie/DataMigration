
using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("bgunwaringstack")]
    public class BgUnWaringStack : EntityBase<int>
    {
        [Column("bgdataguid")]
        public virtual string BGDataGuid { get; set; }
        [Column("hcpopenid")]
        public virtual string HcpOpenId { get; set; }
        [Column("time")]
        public virtual DateTime? Time { get; set; }
        [Column("patientid")]
        public virtual int PatientId { get; set; }
        [Column("createtime")]
        public virtual DateTime? CreateTime { get; set; }
        [Column("unwarningbybgdataguid")]
        public virtual string UnWarningByBGDataGuid { get; set; }
        [Column("unwarningtime")]
        public virtual DateTime? UnWarningTime { get; set; }
        [Column("updatetime")]
        public virtual DateTime? UpdateTime { get; set; }
    }
}