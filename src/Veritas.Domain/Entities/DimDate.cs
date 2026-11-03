using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class DimDate
    {
        [Key]
        public int DateKey { get; set; }
        public DateTime FullDate { get; set; }
        public string DayName { get; set; }
        public byte Month { get; set; }
        public byte Quarter { get; set; }
        public short Year { get; set; }
    }
}
