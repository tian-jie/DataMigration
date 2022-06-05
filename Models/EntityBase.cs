using System;

namespace Infrastructure.Core
{
    public class IEntity { }

    /// <summary>
    /// 可持久化到数据库的数据模型基类
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class EntityBase<TKey> : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        protected EntityBase()
        {
            //IsDeleted = false;
            // CreatedTime = DateTime.Now;
        }

        #region 属性

        /// <summary>
        /// 
        /// </summary>
        public virtual TKey Id { get; set; }

        /// <summary>
        /// 获取或设置 版本控制标识，用于处理并发
        /// </summary>
        public byte[] Timestamp { get; set; }

        #endregion

        #region 方法

        ///// <summary>
        ///// 判断两个实体是否是同一数据记录的实体
        ///// </summary>
        ///// <param name="obj">要比较的实体信息</param>
        ///// <returns></returns>
        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //    {
        //        return false;
        //    }
        //    EntityBase<TKey> entity = obj as EntityBase<TKey>;
        //    if (entity == null)
        //    {
        //        return false;
        //    }
        //    return Id.Equals(entity.Id) && CreatedTime.Equals(entity.CreatedTime);
        //}

        ///// <summary>
        ///// 用作特定类型的哈希函数。
        ///// </summary>
        ///// <returns>
        ///// 当前 <see cref="T:System.Object"/> 的哈希代码。
        ///// </returns>
        //public override int GetHashCode()
        //{
        //    return Id.GetHashCode() ^ CreatedTime.GetHashCode();
        //}

        #endregion
    }
}
