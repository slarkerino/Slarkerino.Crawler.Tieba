using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Crawler.Tieba.Forums
{
    public class Forum : FullAuditedEntity<Guid>, IMultiTenant
    {
        public virtual string Name { get; protected set; }

        public virtual string Url { get; protected set; }

        public virtual long? ForumId { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }
    }
}