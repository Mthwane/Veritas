using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class AuditLog
    {
        [Key]
        public long Id { get; set; }
        public string EntityType { get; set; }
        public string EntityId { get; set; }
        public string Action { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
        public string UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string PrevHash { get; set; }
        public string Hash { get; set; }
    }
}
