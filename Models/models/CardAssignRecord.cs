using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lilly.LCCP.Backend.Models
{
    public class CardAssignRecord : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string RecordId { get; set; }
        public virtual string FromSRId { get; set; }
        public virtual string FromDctrId { get; set; }
        public virtual string ToSRId { get; set; }
        public virtual string ToDctrId { get; set; }
        public virtual int Num { get; set; }
        public virtual int? VersionNumber { get; set; }
        public virtual int? OwnerId { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual int? ModifiedId { get; set; }
        public virtual DateTime? ModifiedUtc { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}