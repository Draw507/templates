using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using $safeprojectname$.Contexts;
using $safeprojectname$.Interfaces;
using $safeprojectname$.Repositories;

namespace $safeprojectname$
{
    public class EFUnitOfWork : IUnitOfWork, IDisposable
    {
        private ApplicationDbContext _context;

        private ICliente _cliente;

        public EFUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICliente Clientes {
            get {
                if (_cliente == null)
                {
                    _cliente = new ClienteRepository(_context);
                }

                return _cliente;
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
