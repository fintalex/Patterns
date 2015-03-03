using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.SingletonExample
{
	public interface UserDataBase
	{
		User ReadUser(string userName);
		void WriteUser(User user);
	}
}
