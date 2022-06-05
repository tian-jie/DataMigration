using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class KouDaiMessageSession : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int PatientId { get; set; }
        public virtual string HcpId { get; set; }
        public virtual string SessionId { get; set; }
        public virtual bool IsFree { get; set; }
        public virtual DateTime? OpenTime { get; set; }
        public virtual string OpenBy { get; set; }
        public virtual DateTime? CloseTime { get; set; }
        public virtual string CloseBy { get; set; } 
        public virtual DateTime? CreateTime { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}