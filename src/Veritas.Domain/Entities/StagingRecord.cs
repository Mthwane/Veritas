using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class StagingRecord
    {
        [Key]
        public long Id { get; set; }
        public long BatchId { get; set; }
        public int RowNumber { get; set; }
        public string RawPayload { get; set; }
        public string RowHash { get; set; }
        public DateTime IngestedAt { get; set; }
    }
}
