using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("cdscasehistory")]
    public class CDSCaseHistory : EntityBase<int>
    {
        [Column("caseid")]
        public virtual string CaseID { get; set; }
        [Column("casetype")]
        public virtual string CaseType { get; set; }
        [Column("hcpids")]
        public virtual string HcpIds { get; set; }
        [Column("message")]
        public virtual string Message { get; set; }
        [Column("createtime")]
        public virtual DateTime? CreateTime { get; set; }        
    }
}