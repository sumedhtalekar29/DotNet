using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
	class Program
	{
		static List<Employee> lstEmp = new List<Employee>();

		static void Main(string[] args)
		{
			Func<decimal, decimal, decimal, decimal> SimpleInterest = (p, n, r) =>
				 {
					 decimal s;
					 s = (p * n * r) / 100;
					 return s;
				 };

			Console.WriteLine("SimpleInterest is " + SimpleInterest(10000, 10, 3));

			Func<int, int, bool> isGreater = (a, b) =>
				  {
					  return a > b;
				  };
			Console.WriteLine("a is grater than b "+isGreater(10,50));

			Func<decimal, decimal> GetBasic = (e) =>
			 {
				 
				 return e;
			 };
			Console.WriteLine("Basic Salary = "+GetBasic(10000));

			Predicate<int> isEven = (a) =>
			{
				return a % 2 == 0;
			};
			Console.WriteLine("enter number is even? "+isEven(10));
			

			Func<decimal,bool> IsGreaterThan = (e) =>
			{
				
				return e>10000;
			};
			Console.WriteLine("is Salary is Greater Than 10000? " + IsGreaterThan(15000));
			Console.ReadLine();
		}
	}

	public class Employee
	{
		public int EmpNo { get; set; }
		public string Name { get; set; }
		public decimal Basic { get; set; }
		public int DeptNo { get; set; }


		
	}
}
