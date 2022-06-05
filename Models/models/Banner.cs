using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class Banner : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string Content { get; set; }
        public virtual string ImageName { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string LinkUrl { get; set; }
        public virtual DateTime? StartUTC { get; set; }
        public virtual DateTime? EndUTC { get; set; }
        public virtual int? ModifiedId { get; set; }
        public virtual DateTime? CreateUTC { get; set; }
        public virtual DateTime? ModifiedUTC { get; set; }
        public virtual bool IsDeleted { get; set; }       
    }
}