using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        // Create a data source by using a collection initializer.
        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
            new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
            new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
            new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
            new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
            new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
            new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}},
            new Student {First="Gaga", Last="Lady", ID=123, Scores = new List<int> {76, 68, 91, 90}},
        };

        static void Main(string[] args)
        {
            // Query that select all stu whose score on the first test > 90
            IEnumerable<Student> studentsQuery1 =
                from student in students
                where student.Scores[0] > 90
                orderby student.Last ascending
                select student;
            // Excute the query above
            foreach (var student in studentsQuery1)
                Console.WriteLine("{1}, {0}", student.First, student.Last);

            Console.WriteLine();

            // Query that select all stu whose score in the first test > 90 and the forth test < 80
            IEnumerable<Student> studentsQuery2 =
                from stu in students
                where stu.Scores[0] > 90 && stu.Scores[3] < 80
                orderby stu.Scores[2] descending
                select stu;
            // Excute
            foreach (var student in studentsQuery2)
                Console.WriteLine("{0}, {1}, {2}", student.First, student.Last, student.Scores[2]);

            Console.WriteLine();

            // Query that group the result (using IGrouping)
            var studentsQuery3 =
                from stu in students
                group stu by stu.Last[0];
            // Excute
            foreach (var studentGroup in studentsQuery3)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student stu in studentGroup)
                    Console.WriteLine("     {0}, {1}", stu.Last, stu.First);
            }

            Console.ReadKey();
        }
    }
}
