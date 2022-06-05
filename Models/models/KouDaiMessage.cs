using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class KouDaiMessage : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int PatientId { get; set; }
        public virtual string HcpId { get; set; }
        public virtual string SessionId { get; set; }
        public virtual DateTime? MessageTime { get; set; }
        public virtual bool IsHcpOnline { get; set; }
        public virtual bool IsPatientOnline { get; set; }
        public virtual bool IsHcpRead { get; set; }
        public virtual string From { get; set; } 
        public virtual DateTime? CreateTime { get; set; }
        public virtual DateTime? HcpReadTime { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual bool? IsFree { get; set; }
        public virtual bool? IsFirst { get; set; }
    }
}