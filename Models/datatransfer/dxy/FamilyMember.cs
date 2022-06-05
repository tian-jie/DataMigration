using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_FamilyMember : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        // 2018-09-19 Add Start ------>
        public virtual string Contacts_simuid { get; set; }
        // 2018-09-19 Add End   ------<
        public virtual int? Pid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Gender { get; set; }
        public virtual int? Relationship { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-03-29 Add Start ------>
        public virtual string Simuid { get; set; }
        // 2017-03-29 Add End   ------<
        // 2017-09-05 Add Start ------>
        public virtual int? Ensure_id { get; set; }
        public virtual int? Sign_time { get; set; }
        // 2017-09-05 Add End   ------<
        // 2018-10-31 Add Start ------>
        public virtual int? Has_cellphone { get; set; }
        // 2018-10-31 Add End   ------<
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public virtual int? Created { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        public virtual int? Origin { get; set; }
        // 2018-03-15 Add End   ------<
    }
}