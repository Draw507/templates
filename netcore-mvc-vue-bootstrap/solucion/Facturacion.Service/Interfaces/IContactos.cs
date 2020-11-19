using Facturacion.Entities;
using Facturacion.Entities.DTO;
using Facturacion.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Service.Interfaces
{
    public interface IContactos
    {
        Task<CommonResponse<IEnumerable<ClienteDTO>>> GetClientes();
        IEnumerable<ClienteDTO> GetClientes(GridRequest<ContactosFilters> gridRequest);
    }
}
