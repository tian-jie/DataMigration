
using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

// нч
namespace InnoCellence.Lccp.Data.Models
{
    [Table("bgdata")]
    public class BGData : EntityBase<int>
    {
        [Column("id")]
        public override int Id { get; set; }
        [Column("dataguid")]
        public virtual string DataGuid { get; set; }
        [Column("patientid")]
        public virtual int PatientId { get; set; }
        [Column("value")]
        public virtual decimal? Value { get; set; }
        [Column("time")]
        public virtual DateTime? Time { get; set; }
        [Column("txlevel")]
        public virtual int? TXLevel { get; set; }
        [Column("timerange")]
        public virtual int? TimeRange { get; set; }
        [Column("lccplevel")]
        public virtual int? LCCPLevel { get; set; }
        [Column("versionnumber")]
        public virtual int? VersionNumber { get; set; }
        [Column("ownerid")]
        public virtual int? OwnerId { get; set; }
        [Column("createdutc")]
        public virtual DateTime? CreatedUtc { get; set; }
        [Column("modifiedid")]
        public virtual int? ModifiedId { get; set; }
        [Column("modifiedutc")]
        public virtual DateTime? ModifiedUtc { get; set; }
        [Column("isdeleted")]
        public virtual bool IsDeleted { get; set; }
        [Column("bgdataid")]
        public virtual Int64? BGDataId { get; set; }
        [Column("imei")]
        public virtual string Imei { get; set; }
        [Column("o_timerange")]
        public virtual int? O_TimeRange { get; set; }
        [Column("status")]
        public virtual string Status { get; set; }
        [Column("lowest")]
        public virtual bool? Lowest { get; set; }
        [Column("low")]
        public virtual bool? Low { get; set; }
        [Column("good1")]
        public virtual bool? Good1 { get; set; }
        [Column("good2")]
        public virtual bool? Good2 { get; set; }
        //public virtual bool? Highest { get; set; }
    }
}