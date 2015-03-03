using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.SingletonExample
{
	//Например, можно гарантировать, что не будет добавлена за-
	//пись User, в которой поле username пусто. Или сериализовать обращения
	//к записи User, так, чтобы никакие два модуля не могли одновременно
	//читать и изменять ее.
	public class UserDataBaseSource : UserDataBase
	{
		private static UserDataBase theInstance = new UserDataBaseSource();

		private UserDataBaseSource() { }

		public static UserDataBase Instance 
		{
			get { return theInstance; }
		}


		public User ReadUser(string userName)
		{
			// реализация
			return new User();
		}

		public void WriteUser(User user)
		{
			// реализация
		}
	}
	//Такое использование паттерна Одиночка распространено чрезвычайно
	//широко. Гарантируется, что весь доступ к базе данных производится
	//через единственный экземпляр UserDatabaseSource. При этом в UserDatabaseSource
	//очень легко вставлять различные проверки, счетчики и бло-
	//кировки, обеспечивающие выполнение вышеупомянутых соглашений
	//о порядке доступа и структуре кода.
}
