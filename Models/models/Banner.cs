using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("banner")]
    public class Banner : EntityBase<int>
    {
        [Column("content")]
        public virtual string Content { get; set; }
        [Column("imagename")]
        public virtual string ImageName { get; set; }
        [Column("imageurl")]
        public virtual string ImageUrl { get; set; }
        [Column("linkurl")]
        public virtual string LinkUrl { get; set; }
        [Column("startutc")]
        public virtual DateTime? StartUTC { get; set; }
        [Column("endutc")]
        public virtual DateTime? EndUTC { get; set; }
        [Column("modifiedid")]
        public virtual int? ModifiedId { get; set; }
        [Column("createutc")]
        public virtual DateTime? CreateUTC { get; set; }
        [Column("modifiedutc")]
        public virtual DateTime? ModifiedUTC { get; set; }
        [Column("isdeleted")]
        public virtual bool IsDeleted { get; set; }       
    }
}