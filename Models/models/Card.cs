
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace InnoCellence.Lccp.Data.Models
{
    public class Card : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual decimal? DctrId { get; set; }
        public virtual string ProjectHcpId { get; set; }
        public virtual string SalesRepId { get; set; }
        public virtual string CardNumber { get; set; }
        public virtual string PatientCardNumber { get; set; }
        public virtual DateTime? EnrollDate { get; set; }
        public virtual int? VersionNumber { get; set; }
        public virtual int? OwnerId { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual int? ModifiedId { get; set; }
        public virtual DateTime? ModifiedUtc { get; set; }
        public virtual bool IsDeleted { get; set; }

        //LCCP
        public virtual int? PatientId { get; set; }
        public virtual DateTime? PatientBindingTime { get; set; }
        public virtual DateTime? RegistedTime { get; set; }
        // 2017/06/23 Add Start ------>
        public virtual string IsLock { get; set; }
        public virtual string IsUse { get; set; }
        public virtual string IsVirtualCard { get; set; }
        public virtual DateTime? ApplyTime { get; set; }
        public virtual string PatientOpenId { get; set; }
        // 2017/06/23 Add End   ------<

        // 2018/05/09 Add Start ------>
        public virtual bool? IsStar { get; set; }
        // 2018/05/09 Add End   ------<

        public virtual int PatientStatus { get; set; }
        public virtual int IsLatest { get; set; }
    }
}