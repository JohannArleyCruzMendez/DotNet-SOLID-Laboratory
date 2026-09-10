using BootcampTech.Data;
using BootcampTech.Domain;
using Microsoft.EntityFrameworkCore;

using var context = new BootcampContext();


var Bootcamp = new Bootcamp {

       Name = "Bootcamp Backend .NET"

};



var Cursos = new List<Course> {

     new Course{

         Title = "Arquitectura de Software",
         Description ="aprender clean architecture ",
         Price = 10000m,

     },

     new Course{

         Title = "POO",
         Description =" Aprender programacion oprientada a objetos ",
         Price = 8000m


         } };


 //Bootcamp.Courses = Cursos;

 // context.bootcamps.Add( Bootcamp );

 //await context.SaveChangesAsync();


  // consulta relacional 


var myBootcamp = await context.bootcamps.Include(b=>b.Courses).FirstOrDefaultAsync();

if (myBootcamp != null)
{
    // 1. Imprime el nombre del Bootcamp
    Console.WriteLine($"Bootcamp: {myBootcamp.Name}");

    // 2. Itera sobre los cursos y los imprime tabulados (\t)
    foreach (var curso in myBootcamp.Courses)
    {
        Console.WriteLine($"\t- Curso: {curso.Title} (Precio: {curso.Price})");
    }
}











