using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class ReviewAction
    {
        [Key]
        public long Id { get; set; }
        public long QuarantineItemId { get; set; }
        public string ActionedBy { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string Comment { get; set; }
        public DateTime ActionedAt { get; set; }
    }
}
