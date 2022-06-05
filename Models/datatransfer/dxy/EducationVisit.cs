using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_EducationVisit : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        // 2017-01-29 Delete Start ------>
        //public virtual string Date { get; set; }
        // 2017-01-29 Delete End   ------<
        public virtual int? Click_Count { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-09-05 Add Start ------>
        public virtual string Send_time { get; set; }
        public virtual int? MaterialId { get; set; }
        public virtual string Material_title { get; set; }
        public virtual int? Sended_count { get; set; }
        public virtual string Statistics_time { get; set; }
        public virtual int? Material_readership { get; set; }
        public virtual int? Origin_readership { get; set; }
        public virtual int? Origin_click_count { get; set; }
        public virtual int? Collect_person { get; set; }
        public virtual int? Collect_count { get; set; }
        public virtual int? Share_person { get; set; }
        public virtual int? Share_count { get; set; }
        // 2017-09-05 Add End   ------<
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2017-12-05 Add Start ------>
        public virtual int? GroupId { get; set; }
        // 2017-12-05 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int? SignId { get; set; }
        public virtual int? Created { get; set; }
        // 2018-11-29 Add End   ------<
    }
}