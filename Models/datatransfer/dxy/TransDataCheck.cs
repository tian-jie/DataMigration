using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class TransDataCheck : EntityBase<int>
    {
        public override int Id { get; set; } 
        public virtual string TableName { get; set; }
        public virtual string Source { get; set; }
        public virtual int Total { get; set; }
        public virtual int Temp { get; set; }
        public virtual int DDCTotal { get; set; }
        public virtual int DDCTemp { get; set; }
        public virtual string Start { get; set; }
        public virtual string End { get; set; }
        public virtual decimal FaultTolerant { get; set; }
        public virtual bool IsError { get; set; }
        public virtual bool IsNoticed { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime CreateTime { get; set; }
        public virtual string JobId { get; set; } 
        public virtual string Message { get; set; }
    }
}