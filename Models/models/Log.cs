
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class Log : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string LogId { get; set; }
        public virtual decimal? DctrId { get; set; }
        public virtual string HcpId { get; set; }
        public virtual string ControllerName { get; set; }
        public virtual string ActionName { get; set; }
        public virtual string Message { get; set; }
        public virtual int? VersionNumber { get; set; }
        public virtual int? OwnerId { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual int? ModifiedId { get; set; }
        public virtual DateTime? ModifiedUtc { get; set; }
        public virtual bool IsDeleted { get; set; }
        //new
        public virtual string LogType { get; set; }
        public virtual int Duration { get; set; }    //based on seconds
        public virtual string RequestIP { get; set; }
        public virtual string RequestURL { get; set; }
        public virtual string PageId { get; set; }
        public virtual string FormData { get; set; }

        public Log()
        {
            CreatedUtc = DateTime.UtcNow;
            OwnerId = 0;
            IsDeleted = false;
        }
    }
}