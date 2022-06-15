using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lilly.LCCP.Backend.Models
{
    [Table("cardassignrecord")]
    public class CardAssignRecord : EntityBase<int>
    {
        [Column("recordid")]
        public virtual string RecordId { get; set; }
        [Column("fromsrid")]
        public virtual string FromSRId { get; set; }
        [Column("fromdctrid")]
        public virtual string FromDctrId { get; set; }
        [Column("tosrid")]
        public virtual string ToSRId { get; set; }
        [Column("todctrid")]
        public virtual string ToDctrId { get; set; }
        [Column("num")]
        public virtual int Num { get; set; }
        [Column("versionnumber")]
        public virtual int? VersionNumber { get; set; }
        [Column("ownerid")]
        public virtual int? OwnerId { get; set; }
        [Column("createdutc")]
        public virtual DateTime? CreatedUtc { get; set; }
        [Column("modifiedid")]
        public virtual int? ModifiedId { get; set; }
        [Column("modifiedutc")]
        public virtual DateTime? ModifiedUtc { get; set; }
        [Column("isdeleted")]
        public virtual bool IsDeleted { get; set; }
    }
}