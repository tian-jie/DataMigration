using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class DoctorPatientInteraction : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string HcpID { get; set; }
        public virtual decimal? DctrId { get; set; }
        public virtual int PatientId { get; set; }
        public virtual DateTime? Date { get; set; }
        public virtual int? PraiseNotice { get; set; }
        public virtual int? ReturnNotice { get; set; }
        public virtual DateTime? CreateTime { get; set; }
        // 2018-05-16 Add Start ------>
        public virtual int? Reminders { get; set; }
        // 2018-05-16 Add End   ------<
    }
}