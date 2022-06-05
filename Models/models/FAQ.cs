
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class FAQ : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int? TypeId { get; set; }
        public virtual string TypeName { get; set; }
        public virtual string Question { get; set; }
        public virtual string Answer { get; set; }
        public virtual string Keywords { get; set; }
        public virtual int? Version { get; set; }
        public virtual string Comment { get; set; }
        public virtual bool? IsDeleted { get; set; }
        public virtual int? WatchNum { get; set; }
    }
}