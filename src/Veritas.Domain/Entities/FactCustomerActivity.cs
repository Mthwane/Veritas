using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class FactCustomerActivity
    {
        [Key]
        public int Factid { get; set;  }
        public int CustomerKey { get; set; }
        public int DateKey { get; set; }
        public int LocationKey  { get; set; }
        public int LoadBatchId { get; set; }
        public decimal Measure1 { get; set; }
        public int Measure2 { get; set; }
        public DateTime LoadedAt { get; set; }
        
    }
}
