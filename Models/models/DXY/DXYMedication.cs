using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class Lilly_DXY_Data_Medication : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual int Rid { get; set; }
        public virtual int? Pid { get; set; }
        public virtual int? Medical_Order_Id { get; set; }
        public virtual string Insulin_Type { get; set; }
        public virtual string Insulin_Name { get; set; }
        public virtual float? Dosage { get; set; }
        public virtual string Deleted { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public virtual DateTime? UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
    }
}