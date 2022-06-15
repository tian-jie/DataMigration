using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_consent")]
    public class Lilly_DXY_Data_Consent : DxyEntityBase<int>
    {
        [Column("name")]
        public virtual string Name { get; set; }
        [Column("type")]
        public virtual int Type { get; set; }
        [Column("file_path")]
        public virtual string File_Path { get; set; }
        [Column("version")]
        public virtual string Version { get; set; }
        [Column("start_time")]
        public virtual int Start_Time { get; set; }
        [Column("end_time")]
        public virtual int End_time { get; set; }
        [Column("deleted")]
        public virtual int Deleted { get; set; }
        [Column("updated")]
        public virtual int Updated { get; set; }
        [Column("Created")]
        public virtual int Created { get; set; }
    }
}