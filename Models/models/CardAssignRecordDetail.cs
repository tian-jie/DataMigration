using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lilly.LCCP.Backend.Models
{
    public class CardAssignRecordDetail : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string RecordId { get; set; }
        public virtual string CardNumber { get; set; }
        public virtual int? VersionNumber { get; set; }
        public virtual int? OwnerId { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual int? ModifiedId { get; set; }
        public virtual DateTime? ModifiedUtc { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}