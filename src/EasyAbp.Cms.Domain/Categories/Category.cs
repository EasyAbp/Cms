using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.Cms.Categories
{
    public class Category : AggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }
        
        [NotNull]
        public virtual string Name { get; protected set; }

        [NotNull]
        public virtual string ShortName { get; protected set; }

        [CanBeNull]
        public virtual string Description { get; set; }
    }
}