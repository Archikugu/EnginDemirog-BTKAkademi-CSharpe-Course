using System;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Gokhan";
            string student3 = "Ahmet";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Gokhan";
            students[2] = "Ahmet";

            string[] students2 = new string[3] { "Engin", "Gokhan", "Ahmet" };

            string[] students3 = new[] { "Engin", "Gokhan", "Ahmet" };

            string[] students4 = { "Engin", "Gokhan", "Ahmet" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("----Multidimensional Arrays----");
            string[,] regions = new string[5, 3]
            {
               { "Istanbul","Izmit","Balıkesir"},
               { "Ankara","Konya","Kırıkkale"},
               { "Antalya","Adana","Mersin"},
               { "Rize","Trabzon","Samsun"},
               { "Izmir","Mugla","Aydın"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*********");
            }

        }
    }
}
