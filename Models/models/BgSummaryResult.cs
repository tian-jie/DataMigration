using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class BgSummaryResult : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string Date { get; set; }
        public virtual DateTime? CreateTime { get; set; }
        public virtual string Key { get; set; }
        public virtual string Type { get; set; }
        public virtual string Result { get; set; }
        
    }
}