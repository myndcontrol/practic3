using System;
using System.Linq;
using System.Collections.Generic;

namespace pract4
{
    class Program
    {
        //задание 2-4
        class Student
        {
            private string Surname;
            private string Name;
            private string Lastname;
            private int DateOfBirth;
            private int Course;
            private int Group;

            public Student(string sn = "Иванов", string n = "Иван", string ln = "Иванович", int dob = 2000, int c = 1, int g = 12334)
            {
                Surname = sn;
                Name = n;
                Lastname = ln;
                DateOfBirth = dob;
                Course = c;
                Group = g;
            }

            public string Surname_get() { return Surname; }
            public string Name_get() { return Name; }
            public string Lastname_get() { return Lastname; }
            public int DateOfBirth_get() { return DateOfBirth; }
            public int Course_get() { return Course; }
            public int Group_get() { return Group; }

        }

        static void Main(string[] args)
        {
            //задание 1


            string[] month = new[] { "June", "July", "May", "December", "January", "April", "August", "Febrary", "September", "March", "October", "November" };

            //запрос 1
            var selectedMonth = from m in month
                                where m.Length == 4
                                select m;
            foreach (string mon in selectedMonth)
                Console.WriteLine(mon);

            Console.WriteLine();

            //запрос 2

            var choosenMonth = new List<string>();

            foreach (string mon in month)
            {
                if ((mon == "June") || (mon == "July") || (mon == "August") || (mon == "December") || (mon == "January") || (mon == "Febrary"))
                {
                    choosenMonth.Add(mon);
                }

            }

            foreach (string mon in choosenMonth)
                Console.WriteLine(mon);

            Console.WriteLine();

            //запрос 3
            var sortedMonth = month.OrderBy(m => m);
            foreach (string mon in sortedMonth)
                Console.WriteLine(mon);

            Console.WriteLine();

            //запрос 4

            int number = (from m in month where m.Contains('u') && m.Length > 4 select m).Count();
            Console.WriteLine(number);


            //задания 2-4

            List<Student> students = new List<Student>

            {
                new Student ( "Дмитриев", "Ярослав", "Даниилович",2000, 1, 123 ),
                new Student ( "Виноградов", "Константин", "Михайлович",2001, 2, 124 ),
                new Student ( "Григорьев", "Александр", "Иванович",2005, 3, 123 ),
                new Student ( "Петрова", "Олеся", "Давидовна",1999, 1, 125 ),
                new Student ( "Кузькин", "Константин", "Петрович",2003, 2, 120 )
            };

            Console.WriteLine();

            //Запрос 1
            var st = from p in students where p.Course_get() == 1 select p;

            foreach (var n in st)
                Console.WriteLine($"{n.Surname_get()} {n.Name_get()} {n.Lastname_get()}, {n.DateOfBirth_get()} год рождения, {n.Course_get()} курс, группа: {n.Group_get()}");

            Console.WriteLine();

            //запрос 2


            var young = students.Min(p => p.DateOfBirth_get());
            var young2 = from p in students where p.DateOfBirth_get() == young select p;

            foreach (var n in young2)
                Console.WriteLine($"{n.Surname_get()} {n.Name_get()} {n.Lastname_get()}, {n.DateOfBirth_get()} год рождения, {n.Course_get()} курс, группа: {n.Group_get()}");
            Console.WriteLine();


            //Запрос 3
            var group = from p in students where p.Group_get() == 123 select p;

            foreach (var n in group)
                Console.WriteLine($"{n.Surname_get()} {n.Name_get()} {n.Lastname_get()}, {n.DateOfBirth_get()} год рождения, {n.Course_get()} курс, группа: {n.Group_get()}");

            Console.WriteLine();

            //Запрос 4

            var name = (from p in students where p.Name_get() == "Константин" select p).First();

            Console.WriteLine($"{name.Surname_get()} {name.Name_get()} {name.Lastname_get()}, {name.DateOfBirth_get()} год рождения, {name.Course_get()} курс, группа: {name.Group_get()}");
            Console.WriteLine();


            //Запрос 5
            var sort = students.OrderBy(s => s.Surname_get());
            foreach (var n in sort)
                Console.WriteLine($"{n.Surname_get()} {n.Name_get()} {n.Lastname_get()}, {n.DateOfBirth_get()} год рождения, {n.Course_get()} курс, группа: {n.Group_get()}");
        }
    }
}