using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Cards : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int? Pid { get; set; }
        public virtual int Status { get; set; }
        public virtual int Created { get; set; }
        public virtual string Enrollment_Code { get; set; }
        public virtual string Invitation_Code { get; set; }
        public virtual string HcpId { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-09-05 Add Start ------>
        public virtual int? Hcp_binding_time { get; set; }
        public virtual int? Patient_binding_time { get; set; }
        // 2017-09-05 Add End   ------<
        // 2017-10-13 Add Start ------>
        public virtual int Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int Batch { get; set; }
        public virtual int Type { get; set; }
        // 2018-11-29 Add End   ------<
        public virtual int Patient_status { get; set; }
        public virtual int Is_latest { get; set; }
    }
}