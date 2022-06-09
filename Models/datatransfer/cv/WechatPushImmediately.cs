using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_WechatPushImmediately : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual string Simuid { get; set; }
        public virtual string Pid { get; set; }
        public virtual string Type { get; set; }
        public virtual string Json { get; set; }
        public virtual string Result_code { get; set; }
        public virtual string Result_msg { get; set; }
        public virtual string Temp_id { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual string Updated { get; set; }
        public virtual string Created { get; set; }
    }
}