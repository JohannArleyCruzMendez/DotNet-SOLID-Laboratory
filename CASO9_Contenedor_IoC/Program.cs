using CASO9_Contenedor_IoC.App;
using CASO9_Contenedor_IoC.Interface;
using CASO9_Contenedor_IoC.Services;
using Microsoft.Extensions.DependencyInjection;

// 1. Crear la colección de servicios
var services = new ServiceCollection();

// 2. Registrar las dependencias (El manual de instrucciones del contenedor)
services.AddTransient<IMessageService, EmailService>(); // "Cuando alguien pida IMessageService, dale un EmailService"
services.AddTransient<App>(); // Registramos la clase principal

// 3. Construir el proveedor (El motor que fabrica los objetos)
var serviceProvider = services.BuildServiceProvider();

// 4. Solicitar la clase principal ya ensamblada y ejecutarla
var miAplicacion = serviceProvider.GetService<App>();
miAplicacion.Run();