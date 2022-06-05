using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_TencentAEPC : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Patient_name { get; set; }
        public virtual int? Patient_birthday { get; set; }
        public virtual int? Patient_sex { get; set; }
        public virtual string Patient_phone { get; set; }
        public virtual string Patient_case_histroy { get; set; }
        public virtual string Patient_imei { get; set; }
        public virtual string Reporter_name { get; set; }
        public virtual string Reporter_relationship { get; set; }
        public virtual string Reporter_phone { get; set; }
        public virtual int? Reporter_report_time { get; set; }
        public virtual string Reporter_report_way { get; set; }
        public virtual int? Event_ID { get; set; }
        public virtual string Event_description { get; set; }
        public virtual int? Event_create_time { get; set; }
        public virtual int? Event_status { get; set; }
        public virtual string Event_category { get; set; }
        public virtual int? Event_dxy_report_time { get; set; }
        public virtual int? Event_dxy_report_source { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
    }
}