using com.draw507.basededatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace com.draw507.basededatos
{
    /*
    public class EFUnidadDeTrabajo : IUnidadDeTrabajo, IDisposable
    {
        private readonly DM_NIIF_09Entities _context;
        private RepositorioPD _pdRepositorio;

        public EFUnidadDeTrabajo()
        {
            _context = new DM_NIIF_09Entities();
        }

        public RepositorioPD RepositorioPD => _pdRepositorio ?? (_pdRepositorio = new RepositorioPD(_context));
        
        public int UoWExecuteSqlCommand(string query)
        {
            return _context.Database.ExecuteSqlCommand(query);
        }

        public List<T> UoWExecuteSqlQuery<T>(string query)
        {
            return _context.Database.SqlQuery<T>(query).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    */
}
