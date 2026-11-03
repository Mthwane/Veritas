using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{


    public class SourceSystem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExpectedFormat { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
        

        

        

        

        

       

        

        

       

       

       

        

       

        

        

       

        
    

