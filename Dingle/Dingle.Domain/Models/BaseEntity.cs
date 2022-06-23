using System;

namespace Dingle.Domain.Models
{
    public abstract class BaseEntity : BaseAudit
    {
        public Guid Id { get; set; }
    }
}
