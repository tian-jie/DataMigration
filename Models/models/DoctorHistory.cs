using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class DoctorHistory : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string LoserHcpId { get; set; }
        public virtual decimal? LoserDctrId { get; set; }
        public virtual string LoserOpenId { get; set; }

        public virtual string WinnerHcpId { get; set; }
        public virtual decimal? WinnerDctrId { get; set; }
        public virtual string WinnerOpenId { get; set; }

        public virtual string Comment { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime? UpdateTime { get; set; }
        public virtual string Notes { get; set; }
    }
}