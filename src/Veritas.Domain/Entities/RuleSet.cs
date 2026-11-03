using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class RuleSet
    {
        [Key]
        public int Id { get; set; }
        public int SourceSystemId { get; set; }
        public string Name { get; set; }
        public int VersionNumber { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ActivatedAt { get; set; }
    }
}
