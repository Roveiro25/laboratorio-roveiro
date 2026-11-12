using System;
using System.Collections.Generic;
using System.Text;

namespace RO_LibreriaBalones.Entidades
{
    public class Balones
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public DateTime? FechaFabricacion { get; set; }
        public decimal Precio { get; set; }

    }
}
