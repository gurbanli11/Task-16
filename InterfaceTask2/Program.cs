using InterfaceTask2.Models;

namespace InterfaceTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Orkhan", "Gurbanli");
            Console.WriteLine("Generated Email: " + student.CodeEmail);
        }
    }
}