using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsConsoleApp
{
    class SmStudent
    {
        public string Name { get; set; }
        public int Roll { get; set; }
    }
    internal class SmLinq
    {
        static void Main(string[] args)
        {
            List<SmStudent> students = new List<SmStudent>()
            {
                new SmStudent(){Roll=1,Name="Sm"},
                new SmStudent(){Roll=2,Name="Sp"},
                new SmStudent(){Roll=3,Name="At"},
                new SmStudent(){Roll=4,Name="Ap"},
                new SmStudent(){Roll=5,Name="Om"},
                new SmStudent(){Roll=6,Name="Nk"}
            };

            var d=from SmStudent s in students
                  where s.Roll>=2 && s.Roll<=3
                  orderby s.Roll descending
                  select s;

            foreach(var s in d)
            {
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Roll);
                Console.WriteLine("---------------");
            }
        }
    }
}
