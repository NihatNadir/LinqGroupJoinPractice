using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoinPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var studentList = new List<Student>()
            {
                new Student(101,"Alice",1),
                new Student(102,"Bob",2),
                new Student(103,"Charlie",1),
                new Student(104,"David",3),
                new Student(105,"Alex",1),
                new Student(106,"Jacob",2),
                new Student(107,"Mary",2)
            };

            var classeslist = new List<Classes>()
            {
                new Classes(1,"Math"),
                new Classes(2,"Science"),
                new Classes(3,"History")
            };

            var result = classeslist.GroupJoin(studentList,
                c => c.ClassId,
                s => s.ClassId,
                (classesItem, studentItem) => new
                {
                    LessonId = classesItem.ClassId,
                    LessonName = classesItem.ClassName,
                    Students = studentItem.OrderBy(s => s.StudentId)
                    .Select(s => new {s.StudentId,s.StudentName})
                    
                   // Ders id , Ders adı ve öğrencilerin tüm bilgilerinin olduğu yeni liste yaparak
                   // tüm bilgileri burada tutuyoruz. 
                    
                }
                );


            foreach (var item in result) // Önce ders adını yazdırıp dersi alanları ayrıca yazdırıyoruz.
            {
                Console.WriteLine(item.LessonId + " " + item.LessonName + " Dersini alan öğrenciler");
                foreach (var student in item.Students)
                {
                    Console.WriteLine($"  - Öğrenci adı : {student.StudentName} => Öğrenci numarası : {student.StudentId}");
                }
                
            }
            Console.ReadLine();

        }
    }
}
