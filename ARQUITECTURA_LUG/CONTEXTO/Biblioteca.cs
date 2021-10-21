using System;
using System.Data.Entity;
using System.Linq;

namespace CONTEXTO
{
    public class Biblioteca : DbContext
    {
        private static Biblioteca instancia;

        public static Biblioteca obtener_instancia()
        {
            if (instancia == null)
                instancia = new Biblioteca();
            return instancia;
        }

        // El contexto se ha configurado para usar una cadena de conexión 'Biblioteca' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CONTEXTO.Biblioteca' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Biblioteca'  en el archivo de configuración de la aplicación.
        public Biblioteca()
            : base("name=Biblioteca")
        {
        }

        public virtual DbSet<MODELO.COMPARTIR> COMPARTIDOS { get; set; }
        public virtual DbSet<MODELO.MATERIAL> MATERIALES { get; set; }
        public virtual DbSet<MODELO.TEMA> TEMAS { get; set; }



        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MODELO.COMPARTIR>().HasKey(c => c.CODIGO);
            modelBuilder.Entity<MODELO.MATERIAL>().HasKey(c => c.CODIGO);
            modelBuilder.Entity<MODELO.TEMA>().HasKey(c => c.CODIGO);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}