using System;
using System.Text;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Faculty computerScienceFaculty = new Faculty("Комп'ютерних наук");
            computerScienceFaculty.SetupAndDisplayDepartments();

            Console.ReadKey();
        }
    }
    public class Faculty
    {
        public string FacultyName { get; private set; }

        private Department department1 = new Department();
        private Department department2 = new Department();

        public Faculty(string name)
        {
            FacultyName = name;
        }
        public void SetupAndDisplayDepartments()
        {
            Console.WriteLine($"Факультет: {FacultyName}");
            Console.WriteLine(new string('-', 30));

            department1.SetName("Комп'ютерних наук та інженерії програмного забезпечення");
            department1.SetTeacherCount(10);
            department1[0] = "Основи програмування";
            department1[1] = "Об'єктно-орієнтоване програмування";
            department1[2] = "Бази даних";

            department2.SetName("Вищої математики");
            department2.SetTeacherCount(5);
            department2[0] = "Математичний аналіз";
            department2[1] = "Лінійна алгебра та аналітична геометрія";

            department1.DisplayInfo();
            department2.DisplayInfo();
        }
        public class Department
        {
            private string departmentName;
            private int teacherCount;
            private string[] disciplines = new string[5];

            public void SetName(string name)
            {
                departmentName = name;
            }

            public void SetTeacherCount(int count)
            {
                if (count > 0)
                {
                    teacherCount = count;
                }
                else
                {
                    teacherCount = 0; 
                }
            }

            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < disciplines.Length)
                    {
                        return disciplines[index];
                    }
                    return "Невірний індекс";
                }
                set
                {

                    if (index >= 0 && index < disciplines.Length)
                    {
                        disciplines[index] = value;
                    }
                }
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Кафедра: {departmentName}, викладачів: {teacherCount}");
                Console.WriteLine("  Дисципліни:");
                foreach (string discipline in disciplines)
                {
                    if (!string.IsNullOrEmpty(discipline))
                    {
                        Console.WriteLine($"    - {discipline}");
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}

