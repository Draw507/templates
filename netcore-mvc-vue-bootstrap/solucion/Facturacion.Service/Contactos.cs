using Facturacion.Entities;
using Facturacion.Entities.DTO;
using Facturacion.Entities.ViewModels;
using Facturacion.Repository.Interfaces;
using Facturacion.Service.Interfaces;
using Facturacion.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Service
{
    public class Contactos : IContactos
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger<Contactos> logger;

        public Contactos(IUnitOfWork unitOfWork, ILogger<Contactos> logger)
        {
            this.unitOfWork = unitOfWork;
            this.logger = logger;
        }

        public async Task<CommonResponse<IEnumerable<ClienteDTO>>> GetClientes()
        {
            var response = new CommonResponse<IEnumerable<ClienteDTO>>();
            response.Data = await unitOfWork.Clientes
                                .GetAll()
                                .Select(s => new ClienteDTO
                                {
                                    Nombre = s.Nombre
                                })
                                .ToListAsync();

            response.Status = CommonResponseTypeStatus.success.ToString();

            return response;
        }

        public IEnumerable<ClienteDTO> GetClientes(GridRequest<ContactosFilters> gridRequest)
        {
            //Consulta
            var query = unitOfWork.Clientes.AsQueryable()
                        .Select(s => new
                        {
                            s.ClienteId,
                            s.Nombre,
                            s.Identificacion,
                            s.Telefono1,
                            s.Telefono2
                        });

            //Filtros
            if (!string.IsNullOrEmpty(gridRequest.filters.Nombre))
            {
                query = query.Where(w => w.Nombre.Trim().ToUpper().Contains(gridRequest.filters.Nombre.Trim().ToUpper()));
            }

            //OrderBy
            if (gridRequest.order != null)
            {
                int ColumnIndex = gridRequest.order.First().column;
                string ColumnName = gridRequest.columns[ColumnIndex].data;
                ORDER ColumnOrder = gridRequest.order.First().dir.ToUpper() == "ASC" ? ORDER.ASC : ORDER.DESC;

                ColumnName = new ClienteDTO().GetDBNamePropertyAttributeInSearch(ColumnName);

                query = query.OrderBy(ColumnName, ColumnOrder);
            }
            else
            {
                query = query.OrderBy(o => o.Nombre);
            }

            int count = query.Count();

            var results = query
                         .GetPage(gridRequest.page, gridRequest.length)
                         .Select(s => new ClienteDTO
                         {
                             ClienteId = s.ClienteId,
                             Nombre = s.Nombre,
                             Identificacion = s.Identificacion,
                             Telefono1 = s.Telefono1,
                             Telefono2 = s.Telefono2,
                             TotalRows = count
                         })
                         .ToList();

            //Fake
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });
            results.Add(new ClienteDTO { Nombre = "David", Identificacion = "8-888-888", Telefono1 = "123456", Telefono2 = "78910", TotalRows = 20 });

            return results;
        }
    }
}
