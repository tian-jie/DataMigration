using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lilly.LCCP.Backend.Models
{
    [Table("cardassignrecorddetail")]
    public class CardAssignRecordDetail : EntityBase<int>
    {
        [Column("recordid")]
        public virtual string RecordId { get; set; }
        [Column("cardnumber")]
        public virtual string CardNumber { get; set; }
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