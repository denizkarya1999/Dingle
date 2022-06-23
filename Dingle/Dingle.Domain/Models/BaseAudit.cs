using System;

namespace Dingle.Domain.Models
{
    public abstract class BaseAudit
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
