using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class InfluenceProjectHcpInfo : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string HcpId { get; set; }
        public virtual bool IsFeatureActive { get; set; }
        public virtual bool IsAgree { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? AgreeTime { get; set; }
        public virtual DateTime? UpdateTime { get; set; }
        public virtual DateTime CreateTime { get; set; }

    }
}