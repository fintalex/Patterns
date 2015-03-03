using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MonostatePattern
{
	[TestFixture]
	public class MonostateTest
	{
		[Test]
		public void TestInstance()
		{
			Monostate m = new Monostate();
			for (int x = 0; x < 10; x++)
			{
				m.X = x;
				Assert.AreEqual(x, m.X);
			}
		}

		[Test]
		public void TestInstancesBehaveAsOne()
		{
			Monostate m1 = new Monostate();
			Monostate m2 = new Monostate();
			for (int x = 0; x < 10; x++)
			{
				m1.X = x;
				Assert.AreEqual(x, m2.X);
			}
		}
	}
}
