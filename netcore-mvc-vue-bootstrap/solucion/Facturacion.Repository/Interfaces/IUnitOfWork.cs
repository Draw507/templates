using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        ICliente Clientes { get; }
        Task Commit();
    }
}
