using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Core
{
    /// <summary>
    /// DXY系统中的数据传输的基类，主要用于将DXY系统表中的ID变更为我们系统表中的RID
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class DxyEntityBase<TKey> : EntityBase<TKey>
    {
        protected DxyEntityBase() { }

        /// <summary>
        /// DXY系统中的ID，对应到我们系统中，显示为RID
        /// </summary>
        public virtual int Rid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreatedUtc { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public virtual DateTime UpdatedUtc { get; set; }
    }
}