using System;
using University.DAL;
using University.DAL.Models;
using University.DAL.Repositories;

namespace University.ConsoleUI
{
    class ConsoleUI
    {
        private static UnitOfWork unitOfWork = new UnitOfWork();
        static void Main(string[] args)
        {
            //
            //Task 2.
            //
            //var studentRepository = new StudentRepository(new UniversityDbContext());
            //Student student = new Student
            //{
            //    FirstName = "Vasya",
            //    LastName = "Pupkin",
            //    Course = null
            //};
            //studentRepository.InsertStudent(student);
            //studentRepository.Save();

            //
            //Task 3.
            //
            //var students = unitOfWork.StudentRepository.Get();

            //foreach (var student in students)
            //    Console.WriteLine(student.FirstName);

            //
            //Task 4.
            //
            ConsoleUI.ConsoleControl();
        }

        private static void ConsoleControl()
        {
            bool isEntityExit = true;

            while (true)
            {
                isEntityExit = ConsoleUI.SelectEntity();

                if (isEntityExit)
                {
                    ConsoleUI.SelectAction();
                }

                else break;
            }
        }

        private static bool SelectEntity()
        {
            while (true)
            {
                ConsoleUI.PrintEntityMenu();
                string selectedEnttity = Console.ReadLine();

                switch (selectedEnttity)
                {
                    case "1":
                        EntityHandler.IsStudent = true;
                        return true;
                    case "2":
                        EntityHandler.IsCourse = true;
                        return true;
                    case "3":
                        EntityHandler.IsDepartment = true;
                        return true;
                    case "4":
                        return false;
                    default:
                        Console.WriteLine("Wrong choice!");
                        Console.WriteLine();
                        break;
                }
            }            
        }

        private static void SelectAction()
        {
            while (true)
            {
                ConsoleUI.PrintActionMenu();
                string selectedAction = Console.ReadLine();

                switch (selectedAction)
                {
                    case "1":
                        ConsoleUI.PrintEntity();
                        break;
                    case "2":
                        ConsoleUI.AddItem();
                        break;
                    case "3":
                        ConsoleUI.DeleteItem();
                        break;
                    case "4":
                        ConsoleUI.UpdateItem();
                        break;
                    case "5":
                        EntityHandler.SetFalseState();
                        return;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            }
        }

        private static void UpdateItem()
        {
            if (EntityHandler.IsStudent)
            {
                Console.WriteLine("Enter ID:");
                int id = Int32.Parse(Console.ReadLine());
                var newStudent = unitOfWork.StudentRepository.GetByID(id);
                Console.WriteLine("Enter first name:");
                newStudent.FirstName = Console.ReadLine();
                Console.WriteLine("Enter last name:");
                newStudent.LastName = Console.ReadLine();
                unitOfWork.StudentRepository.Update(newStudent);
                unitOfWork.Save();
            }
            if (EntityHandler.IsCourse)
            {
                Console.WriteLine("Enter CourseID:");
                int id = Int32.Parse(Console.ReadLine());
                var newCourse = unitOfWork.CourseRepository.GetByID(id);
                Console.WriteLine("Enter course name:");
                newCourse.CourseName = Console.ReadLine();
                unitOfWork.CourseRepository.Update(newCourse);
                unitOfWork.Save();
            }
            if (EntityHandler.IsDepartment)
            {
                Console.WriteLine("Enter DepartmentID:");
                int id = Int32.Parse(Console.ReadLine());
                var newDepartment = unitOfWork.DepartmentRepository.GetByID(id);
                Console.WriteLine("Enter department name:");
                newDepartment.DepartmentName = Console.ReadLine();
                unitOfWork.DepartmentRepository.Update(newDepartment);
                unitOfWork.Save();
            }
        }

        private static void DeleteItem()
        {
            if (EntityHandler.IsStudent)
            {
                Console.WriteLine("Enter ID:");
                int id = 0;

                while (true)
                {                    
                    id = Int32.Parse(Console.ReadLine());
                    Student student = unitOfWork.StudentRepository.GetByID(id);
                    if (student is null)
                        Console.WriteLine("Enter correct ID:");
                    else break;
                }

                unitOfWork.StudentRepository.Delete(id);
                unitOfWork.Save();
            }
            if (EntityHandler.IsCourse)
            {
                Console.WriteLine("Enter ID:");
                int id = 0;

                while (true)
                {
                    id = Int32.Parse(Console.ReadLine());
                    Course course = unitOfWork.CourseRepository.GetByID(id);
                    if (course is null)
                        Console.WriteLine("Enter correct ID:");
                    else break;
                }

                unitOfWork.CourseRepository.Delete(id);
                unitOfWork.Save();
            }
            if (EntityHandler.IsDepartment)
            {
                Console.WriteLine("Enter ID:");
                int id = 0;

                while (true)
                {
                    id = Int32.Parse(Console.ReadLine());
                    Department department = unitOfWork.DepartmentRepository.GetByID(id);
                    if (department is null)
                        Console.WriteLine("Enter correct ID:");
                    else break;
                }

                unitOfWork.DepartmentRepository.Delete(id);
                unitOfWork.Save();
            }
        }

        private static void AddItem()
        {
            if (EntityHandler.IsStudent)
            {
                var newStudent = new Student();
                Console.WriteLine("Enter first name:");
                newStudent.FirstName = Console.ReadLine();
                Console.WriteLine("Enter last name:");
                newStudent.LastName = Console.ReadLine();
                Console.WriteLine("Enter CourseId:");
                int courseId = Int32.Parse(Console.ReadLine());
                var course = unitOfWork.CourseRepository.GetByID(courseId);
                newStudent.Course = course;
                unitOfWork.StudentRepository.Insert(newStudent);
                unitOfWork.Save();
            }
            if (EntityHandler.IsCourse)
            {
                var newCourse = new Course();
                Console.WriteLine("Enter course name:");
                newCourse.CourseName = Console.ReadLine();
                unitOfWork.CourseRepository.Insert(newCourse);
                unitOfWork.Save();
            }
            if (EntityHandler.IsDepartment)
            {
                var newDepartment = new Department();
                Console.WriteLine("Enter department name:");
                newDepartment.DepartmentName = Console.ReadLine();
                unitOfWork.DepartmentRepository.Insert(newDepartment);
                unitOfWork.Save();
            }
        }

        private static void PrintEntity()
        {
            if (EntityHandler.IsStudent)
            {
                var students = unitOfWork.StudentRepository.Get();

                foreach (var item in students)
                    Console.WriteLine(item.ToString());
            }                
            if (EntityHandler.IsCourse)
            {
                var courses = unitOfWork.CourseRepository.Get();

                foreach (var item in courses)
                    Console.WriteLine(item.ToString());
            }                
            if (EntityHandler.IsDepartment)
            {
                var departments = unitOfWork.DepartmentRepository.Get();

                foreach (var item in departments)
                    Console.WriteLine(item.ToString());
            }
        }

        private static void PrintActionMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select Action:\n1. View Entity.\n2. Add Item.\n3. Delete Item.\n4. Update Item.\n5. Return.");
        }

        private static void PrintEntityMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select Entity:\n1. Student.\n2. Course.\n3. Department.\n4. Exit.");
        }
    }
}
