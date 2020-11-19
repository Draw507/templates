using Facturacion.Repository.Contexts;
using Facturacion.Repository.Interfaces;

namespace Facturacion.Repository.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, ICliente
    {
        public ClienteRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
