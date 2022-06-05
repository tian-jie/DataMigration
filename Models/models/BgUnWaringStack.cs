
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class BgUnWaringStack : EntityBase<int>
    {
        public override int Id { get; set; } 
        public virtual string BGDataGuid { get; set; }
        public virtual string HcpOpenId { get; set; }
        public virtual DateTime? Time { get; set; }
        public virtual int PatientId { get; set; } 
        public virtual DateTime? CreateTime { get; set; }
        public virtual string UnWarningByBGDataGuid { get; set; }
        public virtual DateTime? UnWarningTime { get; set; }
        public virtual DateTime? UpdateTime { get; set; }
    }
}