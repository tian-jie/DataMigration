
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class BGTag : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual DateTime? DisplayDate { get; set; }
        public virtual string TagText { get; set; }
        public virtual string TagType { get; set; }
        public virtual int PatientId { get; set; }
        public virtual string HcpId { get; set; }
        public virtual bool? HasViewed { get; set; }
        public virtual bool? IsCopyFromYesterday { get; set; }
        public virtual DateTime? CreateTime { get; set; }
        public virtual bool? IsDeleted { get; set; }
        public virtual DateTime? ViewTime { get; set; }
    }
}