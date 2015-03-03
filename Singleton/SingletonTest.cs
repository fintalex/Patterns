using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace SingletonPattern
{
	[TestFixture]
	public class SingletonTest
	{
		[Test]
		public void TestSingletonTheSameDuringLive()
		{
			Singleton s1 = Singleton.Instance;
			Singleton s2 = Singleton.Instance;
			Assert.AreEqual(s1, s2);
		}

		[Test]
		public void TestSingletionDoesNotHavePublicConstructor()
		{
			Type typeSingleton = typeof(Singleton);
			ConstructorInfo[] ctrs = typeSingleton.GetConstructors();
			bool ourSingletonHavePublishConstructor = false;
			foreach (ConstructorInfo c in ctrs)
			{
				if (c.IsPublic)
				{
					ourSingletonHavePublishConstructor = true;
					break;
				}
			}
			Assert.IsFalse(ourSingletonHavePublishConstructor);
		}
	}
}
