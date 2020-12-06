using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter how many Student you want");
            int size = Convert.ToInt32(Console.ReadLine());
            Student[] s1 = new Student[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Roll Number");
                int RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                String Name = (Console.ReadLine());
                Console.WriteLine("Enter Marks");
                decimal Marks = Convert.ToDecimal(Console.ReadLine());


                Student s = new Student(RollNo, Name, Marks);
                s1[i] = s;

            }
            Console.WriteLine("Student Details");
            for (int i = 0; i < s1.Length; i++)
            {
                s1[i].show();
            }

            Console.ReadLine();
        }
	}
    struct Student
    {
        private int rollNo;
        public string name;
        public decimal marks;

        public int RollNo
        {
           
            set
            {
                if (value < 120 && value > 0)
                {
                    rollNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid roll no");
                }

            }
            get { return rollNo; }
        }
        public string Name
        {
            
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Invalid Name");
                }
                else
                {
                    name = value;
                }
            }
            get { return name; }

        }
        public decimal Marks
        {
           
            set
            {
                if (value <= 100 && value >= 0)
                {
                    marks = value;
                }
                else
                {
                    Console.WriteLine("Enter correct data");
                }

            }
            get { return marks; }

        }

        public Student(int rollNo=0, string name="no name", decimal marks=0) : this()
        {
            this.RollNo = rollNo;
            this.Name = name;
            this.Marks = marks;
        }

        public void show()
        {
            
            Console.WriteLine("RollNo" + RollNo);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Marks:" + Marks);
			Console.WriteLine();

            
        }


    }

}
