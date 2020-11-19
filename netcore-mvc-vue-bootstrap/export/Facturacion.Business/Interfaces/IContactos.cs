using $ext_safeprojectname$.Entities;
using $ext_safeprojectname$.Entities.DTO;
using $ext_safeprojectname$.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Interfaces
{
    public interface IContactos
    {
        Task<CommonResponse<IEnumerable<ClienteDTO>>> GetClientes();
        IEnumerable<ClienteDTO> GetClientes(GridRequest<ContactosFilters> gridRequest);
    }
}
