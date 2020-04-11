using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.Cms.Articles
{
    public class Article : AggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }

        [NotNull]
        public virtual string Title { get; protected set; }

        [CanBeNull]
        public virtual string Content { get; set; }

        public virtual int ReadCount { get; protected set; }

        protected Article()
        {
        }

        public Article(
            Guid id,
            Guid? tenantId,
            [NotNull] string title,
            [CanBeNull] string content,
            int readCount
        ) : base(id)
        {
            TenantId = tenantId;
            Title = title;
            Content = content;
            ReadCount = readCount;
        }
    }
}
