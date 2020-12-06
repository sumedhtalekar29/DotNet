using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
	class Program
	{
		

		static void Main(string[] args)
		{
			Console.WriteLine("How many employee's Deatils you want to store");
			int i = Convert.ToInt32(Console.ReadLine());
			Employee[] e = new Employee[i];

			for (int j = 0; j < e.Length; j++)
			{
				Console.WriteLine("Enter employee name");
				string name = Console.ReadLine();
				Console.WriteLine("Enter employee number");
				int empNo = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter employee salary");
				decimal salary = Convert.ToDecimal(Console.ReadLine());
				Employee e1 = new Employee();
				e1.Set(empNo, name, salary);
				e[j] = e1;
				//e1.show();
			}


			Console.WriteLine("enter empno");
			int search = Convert.ToInt32(Console.ReadLine());
			for (int y = 0; y < e.Length; y++)
			{

				if (e[y].empNo == search)
				{
					
					e[y].show();
				}

			}

			decimal max = e[0].salary;

			for (int x = 0; x < e.Length; x++)
			{

				if (e[x].salary > max)
				{
					max = e[x].salary;
				}

			}

			Console.WriteLine("highest salary"+max);

			Console.ReadLine();
		}

		public class Employee
		{
			public int empNo;
			public string name;
			public decimal salary;

			public void Set(int empNo, string name, decimal salary)
			{
				this.empNo = empNo;
				this.name = name;
				this.salary = salary;
			}

			public void show()
			{
				Console.WriteLine(empNo);
				Console.WriteLine(name);
				Console.WriteLine(salary);
			}
		}
	}

}
