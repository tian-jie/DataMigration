using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class PatientWechatMsgHistory : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int PatientId { get; set; }
        public virtual string Msg { get; set; }
        public virtual string Response { get; set; }
        public virtual bool IsSuccess { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual string Type { get; set; }

    }
}