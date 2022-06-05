using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class WechatMessageHistory : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string HcpId { get; set; }
        public virtual int? PatientId { get; set; }
        public virtual string Message { get; set; }
        public virtual bool HasSend { get; set; }
        public virtual string Desc { get; set; }
        public virtual DateTime? CreateTime { get; set; }
        public virtual DateTime? UpdateTime { get; set; }
        public virtual string DateMark { get; set; }
        public virtual string Type { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual string MsgID  { get; set; }

    }
}