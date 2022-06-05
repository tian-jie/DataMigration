using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class TTQCaseHistory : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string CaseID { get; set; }
        public virtual string CaseType { get; set; }        
        public virtual string HcpIds { get; set; }
        public virtual string Message { get; set; }
        public virtual DateTime? CreateTime { get; set; }        
    }
}