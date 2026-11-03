using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class RuleApplication
    {
        [Key]
        public long Id { get; set; }
        public long CleanedRecordId { get; set; }
        public int RuleId { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime AppliedAt { get; set; }
    }
}
