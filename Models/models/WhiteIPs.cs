using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class WhiteIPs : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string IP { get; set; }
        public virtual string Type { get; set; }
        public virtual DateTime? CreateUTC { get; set; }
        public virtual DateTime? ModifiedUTC { get; set; }
        public virtual bool IsDeleted { get; set; }       
    }
}