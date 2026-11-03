using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class DimLocation
    {
        [Key]
        public int LocationKey { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
    }
}
