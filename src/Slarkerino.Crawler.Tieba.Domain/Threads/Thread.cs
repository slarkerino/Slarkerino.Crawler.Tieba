using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Crawler.Tieba.Threads
{
    public class Thread : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual string Title { get; protected set; }

        public virtual string Url { get; protected set; }

        public virtual long? ThreadId { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }

    }
}
