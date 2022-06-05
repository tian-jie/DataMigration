using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class HospitalSubDepartment : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int? HospitalDepartmentId { get; set; }
        public virtual string Name { get; set; }
        public virtual int? OwnerId { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual int? ModifiedId { get; set; }
        public virtual DateTime? ModifiedUtc { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}