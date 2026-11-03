using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class CleaningRule
    {
        [Key]
        public int Id { get; set; }
        public int RuleSetId { get; set; }
        public string TargetField { get; set; }
        public string RuleType { get; set; }
        public string Pattern { get; set; }
        public string Replacement { get; set; }
        public string Severity { get; set; }
        public int ExecutionOrder { get; set; }
        public bool IsActive { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
