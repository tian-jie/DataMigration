
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class BGDataRawHistory : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string DataGuid { get; set; }
        public virtual int PatientId { get; set; }
        public virtual decimal? Value { get; set; }
        public virtual DateTime? Time { get; set; }
        public virtual int? TXLevel { get; set; }
        public virtual int? TimeRange { get; set; }
        public virtual int? LCCPLevel { get; set; }
        public virtual int? VersionNumber { get; set; }        
        public virtual int? OwnerId { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual int? ModifiedId { get; set; }
        public virtual DateTime? ModifiedUtc { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual Int64? BGDataId { get; set; }
        public virtual string Imei { get; set; }
        public virtual int? O_TimeRange { get; set; }
        public virtual string Status { get; set; }
        public virtual bool IsValid { get; set; }
        public virtual int BGData_Id { get; set; }
        public virtual DateTime? History_Time { get; set; }
    }
}