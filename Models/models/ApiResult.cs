using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

// 不迁移
namespace InnoCellence.Lccp.Data.Models
{
    [Table("apiresult")]
    public class ApiResult : EntityBase<int>
    {
        [Column("id")]
        public override int Id { get; set; }
        [Column("url")]
        public virtual string Url { get; set; }
        [Column("body")]
        public virtual string Body { get; set; }
        [Column("response")]
        public virtual string Response { get; set; }
        [Column("createddate")]
        public virtual DateTime? CreatedDate { get; set; }
        [Column("message")]
        public virtual string Message { get; set; }
        [Column("type")]
        public virtual string Type { get; set; }
        [Column("issuccess")]
        public virtual bool IsSuccess { get; set; }
        [Column("server")]
        public virtual string Server { get; set; }
    }
}