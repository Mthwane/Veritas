using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class QualityMetric
    {
        [Key]
        public long Id { get; set; }
        public long BatchId { get; set; }
        public string MetricName { get; set; }
        public decimal Value { get; set; }
        public decimal Threshold { get; set; }
        public bool Passed { get; set; }
        public DateTime MeasuredAt { get; set; }
    }
}
