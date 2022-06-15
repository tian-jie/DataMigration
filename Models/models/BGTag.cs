
using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("bgtag")]

    public class BGTag : EntityBase<int>
    {
        [Column("displaydate")]
        public virtual DateTime? DisplayDate { get; set; }
        [Column("tagtext")]
        public virtual string TagText { get; set; }
        [Column("tagtype")]
        public virtual string TagType { get; set; }
        [Column("patientid")]
        public virtual int PatientId { get; set; }
        [Column("hcpid")]
        public virtual string HcpId { get; set; }
        [Column("hasviewed")]
        public virtual bool? HasViewed { get; set; }
        [Column("iscopyfromyesterday")]
        public virtual bool? IsCopyFromYesterday { get; set; }
        [Column("createtime")]
        public virtual DateTime? CreateTime { get; set; }
        [Column("isdeleted")]
        public virtual bool? IsDeleted { get; set; }
        [Column("viewtime")]
        public virtual DateTime? ViewTime { get; set; }
    }
}