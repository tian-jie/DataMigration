using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class InfluenceProjectRoundInfo : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual string Status { get; set; }
    }
}