using Facturacion.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Entities.DTO
{
    public class ClienteDTO : GridTotal
    {
        public Guid ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Email { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax { get; set; }
        public string Celular { get; set; }
        public string Observaciones { get; set; }
    }
}
