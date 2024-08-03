namespace LSP
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student std);
        public abstract string GetCourseDetails();
    }
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            
            Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso en línea {Title}.");
        }

        public override string GetCourseDetails()
        {
            return $"Curso en Línea: {Title}";
        }
    }

    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            
            Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso presencial {Title}.");
        }

        public override string GetCourseDetails()
        {
            return $"Curso Presencial: {Title}";
        }
    }

    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            
            Console.WriteLine($"El estudiante {std.Name} se ha suscrito al curso híbrido {Title}.");
        }

        public override string GetCourseDetails()
        {
            return $"Curso Híbrido: {Title}";
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

}
