using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_cards")]
    public class Lilly_DXY_Data_Cards : DxyEntityBase<int>
    {
        [Column("pid")]
        public virtual int? Pid { get; set; }
        [Column("status")]
        public virtual int Status { get; set; }
        [Column("created")]
        public virtual int Created { get; set; }
        [Column("enrollment_code")]
        public virtual string Enrollment_Code { get; set; }
        [Column("invitation_code")]
        public virtual string Invitation_Code { get; set; }
        [Column("hcpid")]
        public virtual string HcpId { get; set; }
        [Column("hcp_binding_time")]
        public virtual int? Hcp_binding_time { get; set; }
        [Column("patient_binding_time")]
        public virtual int? Patient_binding_time { get; set; }
        [Column("deleted")]
        public virtual int Deleted { get; set; }
        [Column("updated")]
        public virtual int Updated { get; set; }
        [Column("batch")]
        public virtual int Batch { get; set; }
        [Column("type")]
        public virtual int Type { get; set; }
        [Column("patient_status")]
        public virtual int Patient_status { get; set; }
        [Column("is_latest")]
        public virtual int Is_latest { get; set; }
    }
}