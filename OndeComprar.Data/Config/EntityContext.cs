using System.Data.Entity;
using OndeComprar.Model;

namespace OndeComprar.Data.Config
{
    public class EntityContext : DbContext
    {
        public EntityContext() : base("Dafault")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EntityContext, OndeComprar.Data.Migrations.Configuration>("Dafault"));
            //Database.SetInitializer<EntityContext>(null);
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<PalavraChave> PalavraChaves { get; set; }
    }
}
