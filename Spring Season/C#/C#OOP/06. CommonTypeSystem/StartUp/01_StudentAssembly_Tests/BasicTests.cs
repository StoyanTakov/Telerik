﻿namespace StartUp._01_StudentAssembly_Tests
{
    using StudentAssembly.Types;
    using System;

    public static class BasicTests
    {
        public static void TestEquals()
        {
            var test = new StudentAssembly.Models.Student
            {
                FirstName = "George",
                MiddleName = "Brown",
            };

            var test1 = new StudentAssembly.Models.Student
            {
                FirstName = "George",
                MiddleName = "Brown"
            };

            Console.WriteLine(test.ToString());
            Console.WriteLine(test1.ToString());

            Console.WriteLine(test.Equals(test1));
        }

        public static void TestHash()
        {
            var test = new StudentAssembly.Models.Student
            {
                FirstName = "George",
                MiddleName = "Brown",
                LastName = "Topalov",
                Email = "damn@god.loool",
                Faculty = FacultyType.Law
            };

            var test1 = new StudentAssembly.Models.Student
            {
                FirstName = "George",
                MiddleName = "Topalov",
                Faculty = FacultyType.Law
            };

            Console.WriteLine(test.Equals(test1));
            Console.WriteLine(test.GetHashCode());
            Console.WriteLine(test1.GetHashCode());
        }

        public static void TestClone()
        {
            var test = new StudentAssembly.Models.Student
            {
                FirstName = "George",
                MiddleName = "Brown",
                LastName = "Topalov",
                Email = "damn@god.loool",
                Faculty = FacultyType.Law
            };

            var test1 = (StudentAssembly.Models.Student)test.Clone();


            Console.WriteLine(test.ToString());
            Console.WriteLine(test1.ToString());
            Console.WriteLine(test.Equals(test1));
            Console.WriteLine(test.GetHashCode());
            Console.WriteLine(test1.GetHashCode());
        }

        public static void TestCompare()
        {
            var test = new StudentAssembly.Models.Student
            {
                SSN = "1"
            };
            
            var test1 = new StudentAssembly.Models.Student
            {
                SSN = "2"
            };

            Console.WriteLine(test.CompareTo(test1));
        }
    }
}
