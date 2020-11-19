using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Entities
{
    public class ErrorDetails
    {
        public string Id { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }
}
