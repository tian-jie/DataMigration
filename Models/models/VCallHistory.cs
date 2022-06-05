using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class VCallHistory : EntityBase<int>
    {
        public override int Id { get; set; } 
        public virtual string HcpId { get; set; }
        public virtual int PatientId { get; set; }
        public virtual string Phone { get; set; }
        public virtual int PhoneMemberType { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual string Result { get; set; }        
        public virtual bool IsSuccess { get; set; }
    }
}