using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsConsoleApp
{
    class Student
    {
        String name, gender;
        int age;
        public Student(String name, int age, String gender)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Age=" + age);
            Console.WriteLine("Gender=" + gender);
        }
    }
    class Student_subject : Student
    {
        String sub1, sub2, sub3;
        int mark1, mark2, mark3;

        public Student_subject(string sub1, string sub2, string sub3,
            int mark1, int mark2, int mark3,
            String name, int age, String gender
            ) : base(name, age, gender)
        {

            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }
        public void show()
        {
            display();
            Console.WriteLine("{0}={1}", sub1, mark1);
            Console.WriteLine("{0}={1}", sub2, mark2);
            Console.WriteLine("{0}={1}", sub3, mark3);
        }
        public int totalMark()
        {
            return mark1 + mark2 + mark3;
        }
        public float avg()
        {
            return totalMark() / 3;
        }
    }
    class Result : Student_subject
    {
        float avgMark;

        public Result(string sub1, string sub2, string sub3,
            int mark1, int mark2, int mark3,
            String name, int age, String gender)
            : base(sub1, sub2, sub3, mark1, mark2,
                 mark3, name, age, gender)
        {
            this.avgMark = base.avg();
        }
        public float AvgMark
        {
            set { avgMark = value; }
            get
            {
                return avgMark;
            }
        }
        public void disp()
        {
            show();
            Console.WriteLine("Average Mark" + avgMark);
            if (avgMark >= 75)
            {
                Console.WriteLine("distinction");
            }
            else if (avgMark >= 60)
            {
                Console.WriteLine("First class");
            }
            else if (avgMark >= 40)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
    internal class Case1_1
    {
        public static void sortArr(Result[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].AvgMark < arr[j + 1].AvgMark)
                    {
                        Result temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Result rs = new Result("Sci", "Math", "eng", 80, 90, 100, "Sm", 20, "male");
            //rs.disp();

            Result[] studRes = {
                new Result("Sci", "Math", "eng", 80, 90, 100, "Sm", 20, "male"),
                new Result("Sci", "Math", "eng", 40, 60, 70, "Om", 20, "male"),
                new Result("Sci", "Math", "eng", 100, 90, 100, "Pm", 21, "male"),
                new Result("Sci", "Math", "eng", 100, 100, 100, "Rm", 20, "male"),
                new Result("Sci", "Math", "eng", 60, 90, 90, "Km", 20, "male")
            };

            sortArr(studRes);

            foreach (Result result in studRes)
            {
                result.disp();
                Console.WriteLine("----------");
            }
        }
    }
}
