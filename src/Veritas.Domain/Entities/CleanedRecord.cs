using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class CleanedRecord
    {
        [Key]
        public long Id { get; set; }
        public long StagingRecordId { get; set; }
        public int RuleSetId { get; set; }
        public string Status { get; set; }
        public long DuplicateOfId { get; set; }
        public string FullName { get; set; }
        public string IdNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public DateTime CleanedAt { get; set; }
    }
}
