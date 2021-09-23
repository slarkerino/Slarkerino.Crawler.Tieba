using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Slarkerino.Crawler.Tieba.Authors
{
    public class Author : AuditedEntity<Guid>, IMultiTenant
    {

        public virtual long UserId { get; protected set; }

        public virtual string TiebaId { get; protected set; }

        public virtual string UserName { get; protected set; }

        public virtual string NickName { get; protected set; }

        public virtual string Portrait { get; protected set; }

        public virtual Guid? TenantId { get; protected set; }
    }
}
