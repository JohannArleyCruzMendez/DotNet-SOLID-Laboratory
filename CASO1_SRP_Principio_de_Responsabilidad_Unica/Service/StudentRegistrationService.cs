using CASO1_SRP_Principio_de_Responsabilidad_Unica.Entities;
using CASO1_SRP_Principio_de_Responsabilidad_Unica.Notifier;
using CASO1_SRP_Principio_de_Responsabilidad_Unica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO1_SRP_Principio_de_Responsabilidad_Unica.Service
{
    public class StudentRegistrationService
      {

        private readonly StudentRepository _studentRepository;
        private readonly EmailNotifier _Notifier;

        public StudentRegistrationService(StudentRepository studentRepository, EmailNotifier notifier)
        {
            _studentRepository = studentRepository;
            _Notifier = notifier;
        }

        public void RegisterStudent(Student student)
        {
            // 1. Lógica de validación
            if (!student.Email.Contains("@"))
            {
                throw new Exception("Email inválido");
            }

             
            _studentRepository.Save(student);
            _Notifier.SendWelcomeEmail(student.Email);

        }
    }


}
