using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
	public class DB
	{
		public static Employee GetEmployee(string s)
		{
			return Employee.NULL;
		}
	}
}
