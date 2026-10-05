using CASO10_El_Reto_Final.Implementations;
using CASO10_El_Reto_Final.Interfaces;
using CASO10_El_Reto_Final.Repository;
using CASO10_El_Reto_Final.services;
using Microsoft.Extensions.DependencyInjection;
// (Tus usings de las interfaces y servicios)

// 1. Crear la colección de servicios
var services = new ServiceCollection();

// 2. Registrar las abstracciones con sus implementaciones concretas
services.AddTransient<IUserRepository, SqlUserRepository>();
services.AddTransient<INotificationChannel, EmailChannel>();

// 3. Registrar tu orquestador
services.AddTransient<UserRegistrationService>();

// 4. Construir el proveedor
var serviceProvider = services.BuildServiceProvider();

// 5. Ejecutar el caso de uso
var registrationService = serviceProvider.GetService<UserRegistrationService>();

// ¡Tu momento de brillar!
registrationService.Register("Johann Cruz", "¡Bienvenido a BootcampTech, futuro Arquitecto de Software!");