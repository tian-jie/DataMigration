using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("bgsummaryresult")]
    public class BgSummaryResult : EntityBase<int>
    {
        [Column("date")]
        public virtual string Date { get; set; }
        [Column("createtime")]
        public virtual DateTime? CreateTime { get; set; }
        [Column("key")]
        public virtual string Key { get; set; }
        [Column("type")]
        public virtual string Type { get; set; }
        [Column("result")]
        public virtual string Result { get; set; }
        
    }
}