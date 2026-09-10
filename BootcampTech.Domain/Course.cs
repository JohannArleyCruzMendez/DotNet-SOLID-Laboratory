
namespace BootcampTech.Domain
{
    public class Course
    {

        public int CourseId { get; set; }

        public string Title {  get; set; } = string.Empty;

        public string? Description { get; set; }
        
        public decimal Price { get; set;  }

        // llave foreanda 
        public int BootcampId { get; set; }

        // ancla 
        public Bootcamp? Bootcamp { get; set; }

    }
}
