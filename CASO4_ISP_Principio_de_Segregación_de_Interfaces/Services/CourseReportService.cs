using CASO4_ISP_Principio_de_Segregación_de_Interfaces.Entities;
using CASO4_ISP_Principio_de_Segregación_de_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO4_ISP_Principio_de_Segregación_de_Interfaces.Services
{
    public class CourseReportService
    {
        private readonly ICourseReadRepository _courseReadRepository;

        public CourseReportService(ICourseReadRepository courseReadRepository)
        {
            _courseReadRepository = courseReadRepository;
        }


        public void GenerateReport()
        {

            var courses = _courseReadRepository.GetAllCourses();

            Console.WriteLine("=== REPORTE DE CURSOS ===");
            foreach (var course in courses)
            {
                Console.WriteLine($"ID: {course.Id} | Título: {course.Title}");
            }
            Console.WriteLine("=========================");


        }

    }
}
