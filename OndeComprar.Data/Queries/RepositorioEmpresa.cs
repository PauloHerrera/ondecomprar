using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OndeComprar.Data.Config;
using OndeComprar.Model;
using OndeComprar.Model.Interfaces;

namespace OndeComprar.Data.Queries
{
    public class RepositorioEmpresa : IRepositorioEmpresa, IDisposable
    {
        public EntityContext db = new EntityContext();
        
        public List<Empresa> ListaEmpresas()
        {
            try
            {

                var query = from p in db.Empresas
                            select p;

                var empresa = query.ToList();

                return empresa;
            }
            catch (EntitySqlException ex)
            {
                throw new Exception(ex.Message);
            }    
        }

        public void Dispose()
        {
            if (db != null)
            {
                db.Dispose();
                db = null;
            }

            GC.SuppressFinalize(this);
        }

    }
}
