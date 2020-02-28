using System;
using System.Collections.Generic;
using System.Text;

namespace University.ConsoleUI
{
    public class EntityHandler
    {
        public static bool IsStudent { get; set; }

        public static bool IsCourse { get; set; }

        public static bool IsDepartment { get; set; }

        static EntityHandler()
        {
            IsStudent = IsCourse = IsDepartment = false;
        }

        public static void SetFalseState()
        {
            IsStudent = IsCourse = IsDepartment = false;
        }
    }
}
