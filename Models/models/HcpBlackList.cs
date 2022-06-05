using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class HcpBlackList : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual decimal DoctorId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Desc { get; set; }
        public virtual DateTime? Created { get; set; }
        public virtual DateTime? Modified { get; set; }
        public virtual bool IsDeleted { get; set; }

    }
}