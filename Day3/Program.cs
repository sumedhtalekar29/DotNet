using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssign
{
	class Program
	{
		static void Main(string[] args)
		{
			GeneralManager g = new GeneralManager();
			g.Name = "Sumedh";
			g.DeptNo = 10;
			g.Basic = 30000;
			Console.WriteLine(g.Name);
			Console.WriteLine(g.DeptNo);
			Console.WriteLine(g.Basic);

			Manager m = new Manager();
			m.Name = "Sumedh";
			m.DeptNo = 10;
			m.Basic = 30000;
			Console.WriteLine(m.Name);
			Console.WriteLine(m.DeptNo);
			Console.WriteLine(m.Basic);
			
			CEO c = new CEO();
			c.Name = "Sumedh";
			c.DeptNo = 10;
			c.Basic = 30000;
			Console.WriteLine(c.Name);
			Console.WriteLine(c.DeptNo);
			Console.WriteLine(c.Basic);


			Console.ReadLine();

		}
	}

	public abstract class Employee
	{
		private static int tempno=0;

		private string name;
		private int empNo;
		private short deptNo;
		public decimal basic;

		public Employee()
		{
			Console.WriteLine("Employee Department");
			EmpNo = ++tempno;
			Console.WriteLine(EmpNo);
		}

		public int EmpNo
		{
			get;
		}

		public abstract decimal Basic { set; get; }


		public short DeptNo
		{
			set
			{
				if (value <= 0)
				{
					Console.WriteLine("enter valid data");
				}
				else
					deptNo = value;
			}

			get
			{
				return deptNo;
			}
		}


		public string Name
		{
			set
			{
				if (value == " ")
				{
					Console.WriteLine("invalid");

				}
				else
					name = value;

			}

			get
			{
				return name;
			}
		}


		public abstract decimal GetNetSalary(decimal Basic);


	}

	public class Manager : Employee
	{
		private string designation;

		public Manager()
		{
			Console.WriteLine("This is manager department");
		}

		public override decimal Basic
		{
			set
			{
				if (value > 15000 && value < 35000)
				{
					basic = value;
				}
				else
				{ Console.WriteLine("Enter valid Basic"); }
			}
			get { return basic; }

		}

		public string Designation
		{
			set
			{
				if (value != " ")
				{
					designation = value;
				}
				else
					Console.WriteLine("enter valid designation");
			}

			get
			{
				return designation;
			}

		}



		public override decimal GetNetSalary(decimal Basic)
		{     
			decimal HRA = ((Basic * 3) / 100);
			decimal TA = ((Basic * 4) / 100);
			decimal IT = ((Basic * 5) / 100);
			decimal PF = ((Basic * 4) / 100); ;

			decimal NetSalary = Basic + HRA + TA - PF - IT;
			return NetSalary;
		}
	}

	public class GeneralManager : Manager
	{
		private string perks;

		public GeneralManager()
		{
			Console.WriteLine("This is General_Manager department");
		}

		public override decimal Basic
		{
			set
			{
				if (value > 35000 && value < 50000)
				{
					basic = value;
				}
				else
				{ Console.WriteLine("Enter valid Basic"); }
			}
			get { return basic; }
		}
		public string Perks
		{
			set { perks = value; }
			get { return perks; }
		}

		public override decimal GetNetSalary(decimal Basic)
		{
			decimal HRA = ((Basic * 3) / 100);
			decimal TA = ((Basic * 4) / 100);
			decimal IT = ((Basic * 5) / 100);
			decimal PF = ((Basic * 4) / 100); ;

			decimal NetSalary = Basic + HRA + TA - PF - IT;
			return NetSalary;
		}
	}

	public class CEO : Employee
	{
		public CEO()
		{
			Console.WriteLine("This is CEO department");
		}
		public override decimal Basic
		{
			set
			{
				if (value > 50000 && value < 60000)
				{
					basic = value;
				}
				else
				{ Console.WriteLine("Enter valid Basic"); }
			}
			get { return basic; }
		}

		public sealed override decimal GetNetSalary(decimal Basic)
		{
			decimal HRA = ((Basic * 3) / 100);
			decimal TA = ((Basic * 4) / 100);
			decimal IT = ((Basic * 5) / 100);
			decimal PF = ((Basic * 4) / 100); ;

			decimal NetSalary = Basic + HRA + TA - PF - IT;
			return NetSalary;
		}
	}
}
