using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_devicebinding")]
    public class Lilly_DXY_Data_DeviceBinding : DxyEntityBase<int>
    {
        [Column("pid")]
        public virtual int? Pid { get; set; }
        [Column("imei")]
        public virtual string Imei { get; set; }
        [Column("unbinding_reason")]
        public virtual string Unbinding_Reason { get; set; }
        [Column("binding_time")]
        public virtual int? Binding_Time { get; set; }
        [Column("unbinding_time")]
        public virtual int? Unbinding_Time { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
    }
}