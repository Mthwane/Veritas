   using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class CategoryMapping
    {
        [Key]
        public int Id { get; set; }
        public int RuleSetId { get; set; }
        public string FieldName { get; set; }
        public string RawValue { get; set; }
        public string CanonicalValue { get; set; }
    }
}
