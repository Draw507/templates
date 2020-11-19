using $safeprojectname$.Contexts;
using $safeprojectname$.Interfaces;

namespace $safeprojectname$.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, ICliente
    {
        public ClienteRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
