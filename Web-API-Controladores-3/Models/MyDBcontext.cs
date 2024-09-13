using Microsoft.EntityFrameworkCore;

namespace Web_API_Controladores_3.Models
{
    public class MyDBcontext : DbContext
    {
        // Constructor
        public MyDBcontext(DbContextOptions<MyDBcontext> options)
            : base(options)
        {

        }


        // Tablas a Mapear en DB:
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
