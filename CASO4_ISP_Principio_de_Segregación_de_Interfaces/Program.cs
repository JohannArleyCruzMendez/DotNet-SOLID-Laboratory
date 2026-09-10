using CASO4_ISP_Principio_de_Segregación_de_Interfaces.Interfaces;
using CASO4_ISP_Principio_de_Segregación_de_Interfaces.Repositories;
using CASO4_ISP_Principio_de_Segregación_de_Interfaces.Services;



// 1. Creamos la instancia del repositorio (la fuente de datos)
CourseRepository courseRepository = new CourseRepository();

// 2. Pasamos el repositorio al servicio de reportes

CourseReportService reportService = new CourseReportService(courseRepository);

// 3. Ejecutamos la generación del reporte

reportService.GenerateReport();


