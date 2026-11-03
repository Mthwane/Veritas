using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veritas.Domain.Entities
{
    public class LoadBatch
    {
        [Key]
        public long Id { get; set; }
        public int SourceSystemId { get; set; }
        public int RuleSetId { get; set; }
        public string UploadedBy { get; set; }
        public string FileName { get; set; }
        public string FileChecksum { get; set; }
        public string Status { get; set; }
        public int RowsReceived { get; set; }
        public int RowsClean { get; set; }
        public int RowsRepaired { get; set; }
        public int RowsQuarantined { get; set; }
        public int RowsRejected { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
