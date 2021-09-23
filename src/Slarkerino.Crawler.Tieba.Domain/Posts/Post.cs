using Slarkerino.Crawler.Tieba.Authors;
using Slarkerino.Crawler.Tieba.Threads;
using System;

using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Crawler.Tieba.Posts
{
    public class Post : FullAuditedEntity<Guid>, IMultiTenant
    {
        public virtual long? PostId { get; protected set; }

        public virtual int Floor { get; protected set; }

        public virtual int Index { get; protected set; }

        public virtual int CommentNumber { get; protected set; }

        public virtual string Content { get; protected set; }

        public virtual bool IsAnoynomous { get; protected set; }

        public virtual Guid ThreadId { get; protected set; }

        public virtual Thread Thread { get; protected set; }

        public virtual Guid? AuthorId { get; protected set; }

        public virtual Author Author { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }
    }
}