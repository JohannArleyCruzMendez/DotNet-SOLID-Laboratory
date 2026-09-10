using CASO4_ISP_Principio_de_Segregación_de_Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO4_ISP_Principio_de_Segregación_de_Interfaces.Interfaces
{
     public interface ICourseReadRepository
    {
       Course GetCourseById(int id);
        List<Course> GetAllCourses();
    }
}
