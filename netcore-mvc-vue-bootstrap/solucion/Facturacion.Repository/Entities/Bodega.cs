using System;
using System.Collections.Generic;

namespace Facturacion.Repository.Entities
{
    public partial class Bodega
    {
        public Guid BodegaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Observaciones { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}
