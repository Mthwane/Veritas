using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class DimCustomer
    {
        [Key]
        public int CustomerKey { get; set; }
        public string BusinessKey { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool IsCurrent { get; set; }
        public string RowHash { get; set; }
    }
}
