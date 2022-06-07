
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("log")]
    public class Log : EntityBase<int>
    {
        [Column("id")]
        public override int Id { get; set; }
        [Column("logid")]
        public virtual string LogId { get; set; }
        [Column("dctrid")]
        public virtual decimal? DctrId { get; set; }
        [Column("hcpid")]
        public virtual string HcpId { get; set; }
        [Column("controllername")]
        public virtual string ControllerName { get; set; }
        [Column("actionname")]
        public virtual string ActionName { get; set; }
        [Column("message")]
        public virtual string Message { get; set; }
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
        [Column("logtype")]
        public virtual string LogType { get; set; }
        [Column("duration")]
        public virtual int Duration { get; set; }    //based on seconds
        [Column("requestip")]
        public virtual string RequestIP { get; set; }
        [Column("requesturl")]
        public virtual string RequestURL { get; set; }
        [Column("pageid")]
        public virtual string PageId { get; set; }
        [Column("formdata")]
        public virtual string FormData { get; set; }

        public Log()
        {
            CreatedUtc = DateTime.UtcNow;
            OwnerId = 0;
            IsDeleted = false;
        }
    }
}