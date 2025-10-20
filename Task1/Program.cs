namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student newSt = new("Іванов", "студент", 20, "КННІ", "K-01", 3);
            Random arand = new();
            newSt.MyRating(arand);

            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        public Person(string N, string R, int A)
        {
            Name = N;
            Age = A;
            Role = R;
        }

        public string GetName() { return Name; }
    }

    class StudentAssesment
    {

        double[] assesment = new double[10];
        public double StRating(Random arand)
        {
            double rating = 0;
            for (int i = 0; i < 10; i++)
            {

                assesment[i] = arand.Next(56, 101);
                rating += assesment[i];
                Console.Write(assesment[i].ToString() + " ");
            }
 
            return rating / 10;
        }
    }


    class Student : Person
    {
        public string Facultet { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }

        public Student(string N, string R, int A, string F, string G, int C)
            : base(N, R, A)
        {
            Facultet = F;
            Group = G;
            Course = C;
        }

        StudentAssesment strating1 = new();
        StudentAssesment strating2 = new();

        public void MyRating(Random arand)
        {
            Console.WriteLine($"Студент: {Name}");
            Console.WriteLine("------------------------------------------");

            Console.Write("Оцінки за перший модуль: ");
            double Rating1 = strating1.StRating(arand);
            Console.WriteLine($"\nРейтинг за перший модуль = {Rating1:F2}");

            Console.WriteLine("------------------------------------------");

            Console.Write("Оцінки за другий модуль: ");
            double Rating2 = strating2.StRating(arand);
            Console.WriteLine($"\nРейтинг за другий модуль = {Rating2:F2}");

            Console.WriteLine("==========================================");

            double Rating = (Rating1 + Rating2) / 2;
            Console.WriteLine($"Середній рейтинг за семестр = {Rating:F2}");

            switch (Rating)
            {
                case >= 82:
                    Console.WriteLine("Привіт відмінникам!");
                    break;
                case <= 60:
                    Console.WriteLine("Перездача! Треба краще вчитися!");
                    break;
                default:
                    Console.WriteLine("Задовільно");
                    break;
            }
        }
    }
}