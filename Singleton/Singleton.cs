using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
	// это простой singleton
	// характерность :
	// 1. конструктор приватный который может вызываться только внутри
	// 2. статическое свойство объекта, значение которому присваивается только один раз

	// Вместо singletion instance может быть любое свойство которое нам нужно
	public class Singleton
	{
		private static Singleton _instance = null;
		private Singleton()	{}

		public static Singleton Instance 
		{
			get {
				if (_instance == null)
					new Singleton();
				return _instance;
			}
		}
	}
}
