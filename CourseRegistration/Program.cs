using System.Linq.Expressions;

namespace CourseRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Console.Write("Enter credit hours: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int hours))
                {
                    Console.WriteLine("Invalid number");
                    return;
                }
                CourseRegistration course = new CourseRegistration(name, hours);
                Console.WriteLine();
                Console.WriteLine("RegistrationSuccessFul!");
                Console.WriteLine("Student Name: " + course.StudentName);

                Console.WriteLine("CreditHours: " + course.CreditHours);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Erorr: " + ex.Message);
            }
        }
    }
}


        
    
   




    

