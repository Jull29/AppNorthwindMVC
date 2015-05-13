using System.Data.Entity;
using AppNorthwindMVC.Models;

namespace AppNorthwindMVC
{
    public class NORTHWNDEntities : DbContext
    {
        // Puede agregar código personalizado a este archivo. Los cambios no se sobrescribirán.
        // 
        // Si desea que Entity Framework lo omita y regenere la base de datos
        // automáticamente siempre que cambie el esquema de modelo, agregue
        // el siguiente código al método Application_Start en el archivo Global.asax.
        // Nota: esta operación destruirá y volverá a crear la base de datos con cada cambio de modelo.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<AppNorthwindMVC.NORTHWNDEntities>());

        public NORTHWNDEntities() : base("name=NORTHWNDEntities")
        {
        }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Suppliers> Suppliers { get; set; }
    }
}
