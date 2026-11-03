using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class QuarantineItem
    {
        [Key]
        public long Id { get; set; }
        public long CleanedRecordId { get; set; }
        public int FailedRuleId { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public string ResolvedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ResolvedAt { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
