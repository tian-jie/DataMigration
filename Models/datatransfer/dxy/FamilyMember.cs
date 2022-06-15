using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_familymember")]
    public class Lilly_DXY_Data_FamilyMember : DxyEntityBase<int>
    {
        [Column("contacts_simuid")]
        public virtual string Contacts_simuid { get; set; }
        [Column("pid")]
        public virtual int? Pid { get; set; }
        [Column("name")]
        public virtual string Name { get; set; }
        [Column("gender")]
        public virtual string Gender { get; set; }
        [Column("relationship")]
        public virtual int? Relationship { get; set; }
        [Column("simuid")]
        public virtual string Simuid { get; set; }
        [Column("ensure_id")]
        public virtual int? Ensure_id { get; set; }
        [Column("sign_time")]
        public virtual int? Sign_time { get; set; }
        [Column("has_cellphone")]
        public virtual int? Has_cellphone { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
        [Column("created")]
        public virtual int? Created { get; set; }
        [Column("origin")]
        public virtual int? Origin { get; set; }
    }
}