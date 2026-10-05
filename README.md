# 🧪 DotNet SOLID Laboratory

Un repositorio práctico enfocado en la refactorización de código y el diseño de software limpio. Este laboratorio demuestra la aplicación de los 5 principios SOLID resolviendo problemas de acoplamiento a través del dominio de una plataforma educativa ("BootcampTech").

## 🏗️ Casos de Estudio

La solución está dividida en proyectos independientes que documentan la evolución de la arquitectura:

* **Caso 1 (SRP):** Desacoplamiento de la lógica de persistencia y notificación en el registro de estudiantes.
* **Caso 2 (OCP):** Implementación del Patrón Estrategia para escalar descuentos de cursos (Regular, Premium, Becado).
* **Caso 3 (LSP):** Refactorización de herencias rotas entre cursos presenciales y online garantizando la sustitución segura.
* **Caso 4 (ISP):** División de repositorios masivos en contratos específicos de lectura y escritura.
* **Caso 5 (DIP):** Inversión de dependencias para orquestar pasarelas de pago intercambiables (Stripe, PayPal).
* **Caso 6 (SRP + ISP):** Diseño de un motor de reportes financieros aislando el cálculo matemático de la exportación a documentos.
* **Caso 7 (OCP + DIP):** Sistema escalable de notificaciones multicanal integrando servicios en la nube reales.

## 🛠️ Tecnologías y Librerías

* C# 12 y .NET 8 (Aplicaciones de Consola)
* QuestPDF (Generación de reportes financieros)
* Twilio SDK y MailKit (Infraestructura de notificaciones)

## 🚀 Cómo Explorar el Laboratorio

Cada carpeta es un entorno aislado. Establece cualquier proyecto `CASO...` como "Startup Project" en tu IDE para inspeccionar las interfaces, los servicios y la raíz de composición en el `Program.cs`.
