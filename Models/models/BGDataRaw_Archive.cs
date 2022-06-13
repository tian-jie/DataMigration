
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("bgdataraw_archive")]
    public class BGDataRaw_Archive : EntityBase<int>
    {

        [Column("dataguid")]
        public virtual string DataGuid { get; set; }
        [Column("patientid")]
        public virtual int PatientId { get; set; }
        [Column("value")]
        public virtual decimal? Value { get; set; }
        [Column("time")]
        public virtual DateTime? Time { get; set; }
        [Column("o_time")]
        public virtual DateTime? O_Time { get; set; }
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
        [Column("isvalid")]
        public virtual bool IsValid { get; set; }
        [Column("date")]
        public virtual string Date { get; set; }
        [Column("lowest")]
        public virtual bool? Lowest { get; set; }
        [Column("low")]
        public virtual bool? Low { get; set; }
        [Column("good1")]
        public virtual bool? Good1 { get; set; }
        [Column("good2")]
        public virtual bool? Good2 { get; set; }
        [Column("highest")]
        public virtual bool? Highest { get; set; }
    }
}