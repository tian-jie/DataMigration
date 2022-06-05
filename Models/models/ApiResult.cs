using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class ApiResult : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string Url { get; set; }
        public virtual string Body { get; set; }
        public virtual string Response { get; set; } 
        public virtual DateTime? CreatedDate { get; set; }
        public virtual string Message { get; set; }
        public virtual string Type { get; set; }
        public virtual bool IsSuccess { get; set; }
        public virtual string Server { get; set; }
    }
}