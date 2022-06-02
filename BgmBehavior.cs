using System;
namespace Application
{
    public class BgmBehavior
    {
        public class Lilly_DXY_Data_BgmBehavior
        {
            public virtual int Id { get; set; }
            public virtual int Rid { get; set; }
            public virtual string Imei { get; set; }
            public virtual string Cmd { get; set; }
            public virtual string Value { get; set; }
            public virtual string Version_Name { get; set; }
            public virtual string Version_Code { get; set; }
            public virtual string Time { get; set; }
            public override DateTime CreatedUtc { get; set; }
            public virtual string Deleted { get; set; }
        }
    }
}
}
