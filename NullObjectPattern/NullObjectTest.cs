using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NullObjectPattern
{
	[TestFixture]
	public class NullObjectTest
	{
		[Test]
		public void TestNull()
		{
			Employee e = DB.GetEmployee("Bob");
			if (e.IsTimeToPay(new DateTime()))
				Assert.Fail();
			Assert.AreSame(Employee.NULL, e);
		}

	}
}
