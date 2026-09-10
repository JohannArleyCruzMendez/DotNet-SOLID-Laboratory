using BootcampTech.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace BootcampTech.Data
{
    public class BootcampContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                        
            optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BootcampTech;Integrated Security=True;TrustServerCertificate=True").LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, Microsoft.Extensions.Logging.LogLevel.Information).EnableSensitiveDataLogging();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Le decimos que la propiedad Price del Course tendrá 18 dígitos en total y 2 decimales.
            modelBuilder.Entity<Course>().Property(c => c.Price).HasPrecision(18, 2);



            modelBuilder.Entity<Course>()
            .HasOne(c => c.Bootcamp) // Un curso tiene UN bootcamp
            .WithMany(b => b.Courses) // Un bootcamp tiene MUCHOS cursos
            .HasForeignKey(c => c.BootcampId); // La llave foránea es BootcampId




        }



        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Bootcamp> bootcamps { get; set; }




    }
}
