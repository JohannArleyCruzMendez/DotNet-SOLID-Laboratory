using CASO4_ISP_Principio_de_Segregación_de_Interfaces.Entities;
using CASO4_ISP_Principio_de_Segregación_de_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO4_ISP_Principio_de_Segregación_de_Interfaces.Repositories
{
    public class CourseRepository : ICourseReadRepository, ICourseWriteRepository
    {
        public void AddCourse(Course course)
        {
            Console.WriteLine("Agregar curso");
        }

        public void DeleteCourse(int id)
        {
            Console.WriteLine("Borrar curso");
        }

        public List<Course> GetAllCourses()
        {
            return new List<Course>
          {
            new Course { Id = 1, Title = "Programación en C#" },
              new Course { Id = 2, Title = "Bases de Datos SQL" },
             new Course { Id = 3, Title = "Desarrollo Web con ASP.NET" }
             };

        }

        public Course GetCourseById(int id)
        {
            // Reutilizamos la misma lista simulada para buscar el que coincida con el Id
            var listaCursos = GetAllCourses();

            // Busca el primer curso que tenga el mismo Id, si no lo encuentra devuelve null
            return listaCursos.Find(c => c.Id == id);
        }

        public void UpdateCourse(Course course)
        {
            Console.WriteLine("curso actualizado");
        }
    }
}
