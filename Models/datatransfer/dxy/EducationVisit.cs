using Infrastructure.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_educationvisit")]
    public class Lilly_DXY_Data_EducationVisit : DxyEntityBase<int>
    {
        [Column("click_count")]
        public virtual int? Click_Count { get; set; }
        [Column("send_time")]
        public virtual string Send_time { get; set; }
        [Column("materialid")]
        public virtual int? MaterialId { get; set; }
        [Column("material_title")]
        public virtual string Material_title { get; set; }
        [Column("sended_count")]
        public virtual int? Sended_count { get; set; }
        [Column("statistics_time")]
        public virtual string Statistics_time { get; set; }
        [Column("material_readership")]
        public virtual int? Material_readership { get; set; }
        [Column("origin_readership")]
        public virtual int? Origin_readership { get; set; }
        [Column("origin_click_count")]
        public virtual int? Origin_click_count { get; set; }
        [Column("collect_person")]
        public virtual int? Collect_person { get; set; }
        [Column("collect_count")]
        public virtual int? Collect_count { get; set; }
        [Column("share_person")]
        public virtual int? Share_person { get; set; }
        [Column("share_count")]
        public virtual int? Share_count { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("groupid")]
        public virtual int? GroupId { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
        [Column("signid")]
        public virtual int? SignId { get; set; }
        [Column("created")]
        public virtual int? Created { get; set; }
    }
}