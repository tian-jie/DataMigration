using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_bgmbehavior")]
    public class Lilly_DXY_Data_BgmBehavior : DxyEntityBase<int>
    {
        [Column("req_id")]
        public virtual Int64 Req_Id { get; set; }
        [Column("imei")]
        public virtual string Imei { get; set; }
        [Column("cmd")]
        public virtual string  Cmd { get; set; }
        [Column("value")]
        public virtual string Value { get; set; }
        [Column("version_name")]
        public virtual string Version_Name { get; set; }
        [Column("version_code")]
        public virtual string Version_Code { get; set; }
        [Column("time")]
        public virtual string Time { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
        [Column("created")]
        public virtual int? Created { get; set; }
    }
}