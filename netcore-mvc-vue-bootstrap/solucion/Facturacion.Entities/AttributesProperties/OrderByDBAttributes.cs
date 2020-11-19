using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacion.Entities.AttributesProperties
{
    [AttributeUsage(AttributeTargets.Property)]
    public class OrderByDBAttributes : Attribute
    {
        //Nombre del campo en BD
        public string DBName { get; set; }
    }
}
