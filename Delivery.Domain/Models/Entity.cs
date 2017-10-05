using System;

namespace Delivery.Domain.Models
{
    public class Entity
    {
        public Guid Id { get; set; }

        public string CriadoPor { get; set; } = null;

        public string DeletadoPor { get; set; } = null;

        public string AtualizadoPor { get; set; } = null;

        public DateTime? CriadoEm { get; set; }

        public DateTime? DeletadoEm { get; set; }

        public DateTime? AtualizadoEm { get; set; }

        public bool? Deletado { get; set; }

    }
}
