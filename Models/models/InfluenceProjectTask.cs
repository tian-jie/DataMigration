using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class InfluenceProjectTask : EntityBase<int>
    {
        public override int Id { get; set; } 
        public virtual string HcpId { get; set; }
        //public virtual int Level { get; set; } 
        public virtual int Status { get; set; }
        public virtual int InterActionCounter { get; set; }
        public virtual int BgTestCounter { get; set; }
        public virtual int CurrentLevel { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsNoticePushed { get; set; }
        public virtual int? NoticeType { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual DateTime? NoticeTime { get; set; }
    }
    
}