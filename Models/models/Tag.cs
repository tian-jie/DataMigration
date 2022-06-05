
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace InnoCellence.Lccp.Data.Models
{
    public class Tag : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string TagId { get; set; }
        public virtual string TagName { get; set; }
        public virtual string HcpId { get; set; }
        public virtual string PatientIdList { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
    }
}