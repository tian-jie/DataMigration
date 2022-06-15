using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_agent")]
    public class Lilly_DXY_Data_Agent : DxyEntityBase<int>
    {
        [Column("name")]
        public virtual string Name { get; set; }
        [Column("gender")]
        public virtual int? Gender { get; set; }
        [Column("phone_number")]
        public virtual string Phone_number { get; set; }
        [Column("email")]
        public virtual string Email { get; set; }
        [Column("status")]
        public virtual int? status { get; set; }
        [Column("comment")]
        public virtual string Comment { get; set; }
        [Column("activation_time")]
        public virtual int?  Activation_time { get; set; }
        [Column("de_activation_time")]
        public virtual int? De_activation_time { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
    }
}