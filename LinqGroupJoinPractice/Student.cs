using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoinPractice
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }

        public Student(int ogrenciId,string ogrenciAdi,int sinifId)
        {
            StudentId = ogrenciId;
            StudentName = ogrenciAdi;
            ClassId = sinifId;
        }


    }
}
