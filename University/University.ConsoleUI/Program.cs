using System;
using University.DAL;
using University.DAL.Models;
using University.DAL.Tools;

namespace University.ConsoleUI
{
    class Program
    {
        private static UnitOfWork unitOfWork = new UnitOfWork();
        static void Main(string[] args)
        {
            //var studentRepository = new StudentRepository(new UniversityDbContext());
            //Student student = new Student
            //{
            //    FirstName = "Vasya",
            //    LastName = "Pupkin",
            //    Course = null
            //};
            //studentRepository.InsertStudent(student);
            //studentRepository.Save();

           // UnitOfWork unitOfWork = new UnitOfWork();
            var students = unitOfWork.StudentRepository.Get();

            foreach(var student in students)
            Console.WriteLine(student.FirstName);
        }

        private static void PrintSelectEntity()
        {
            Console.WriteLine("Select entity:\n1. Student\n2. Course\n3.Department");
        }

        private void PrintSelectAction()
        {
            Console.WriteLine("\tSelect action:\n\t1. Add\n\t2. Update\n\t3. Delete\n\t4. Print all");
        }

        private static void Do()
        {
            while(true)
            {
                PrintSelectEntity();

            }
        }

        private static void SelectEntity()
        {
            string key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    SelectStudentAction();
                    break;
            }
               
        }

        private static void SelectStudentAction()
        {
            string key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    UpdateStudent();
                    break;
                case "3":
                    DeleteStudent();
                    break;
                case "4":
                    PrintStudent();
                    break;
            }
        }

        private static void AddStudent()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter CourseId:");
            int courseId = Int32.Parse(Console.ReadLine());
            Course course = unitOfWork.CourseRepository.GetByID(courseId);

            if (!course )
            Student student = new Student { FirstName = firstName, LastName = lastName }
        }
    }
}

