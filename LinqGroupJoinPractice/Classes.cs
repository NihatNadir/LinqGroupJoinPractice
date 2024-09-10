using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoinPractice
{
    public class Classes
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public Classes(int sinifId,string sinifAdi) 
        {
            ClassId = sinifId;
            ClassName = sinifAdi;
        }


    }
}
