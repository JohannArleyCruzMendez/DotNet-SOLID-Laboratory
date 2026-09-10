
using CASO2_OCP_Principio_de_Abierto_Cerrado.Discounts;
using CASO2_OCP_Principio_de_Abierto_Cerrado.Services;

CourseDiscountCalculator descuento = new CourseDiscountCalculator();

BecadoDiscount becado = new BecadoDiscount();

Console.WriteLine($"el descuento del curso es {descuento.GenerarDescuento(becado, 2000m)}");
    
    
   


