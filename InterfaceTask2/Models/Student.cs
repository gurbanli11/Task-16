using InterfaceTask2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask2.Models
{
    internal class Student : ICodeAcademy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static int Count=0;
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = Count++;
        }

        public void GenerateEmail()
        {
            string email = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
            CodeEmail = email;
        }
    }
}
