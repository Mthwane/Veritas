using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class BatchStageRun
    {
        [Key]
        public long Id { get; set; }
        public long BatchId { get; set; }
        public string Stage { get; set; }
        public string Status { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public int RowsIn { get; set; }
        public int RowsOut { get; set; }
        public string ErrorMessage { get; set; }
    }
}
