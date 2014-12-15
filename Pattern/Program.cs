using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Pattern
{
	
	class Program
	{
		
		static void Main(string[] args)
		{

			// ======================== Паттерны методов расширения C# ==========================

			//// метод совмещенных вызовов
			//var sb = new StringBuilder();
			//sb.AppendFormatLine("Hello {0}", "world");

			//// метоод добавления рекурсивных вызовов
			//string a = "a", b= "b", c = "c";
			//var path = new[] { a, b, c }.PathCombine();

			//// метод добавления множественных параметров
			//var list = new List<int>();
			//list.AddRange(1, 2, 3, 4, 5);

			//// перенос статического метода в метод расширения
			//int number = 4;
			//var str = "value is {0}".F(number);
			
			//// фабричные методы расширения
			//DateTime dt = 22.June(1998);

			//Console.ReadLine();

			// ========================// ========================// ========================

			// ======================== Singleton==========================
			//Singleton single = Singleton.GetInstanse();
			//single.flag = true;
			//Console.WriteLine("single.flag = " + single.flag);

			//Singleton single2 = Singleton.GetInstanse();
			//single2.flag = false;
			//Console.WriteLine(" Выполнилась операция 'single2.flag = false'");

			//Console.WriteLine(" А изменилось поле single.flag = " + single.flag);

			//Console.ReadLine();
			// ========================// ========================// ========================

			// ======================== Factory Method==========================
			//var factory = new FordFiestaFactory() as ICreateCars;

			//var myCar = factory.CreateACar("red");

			//Console.WriteLine("Make: " + myCar.Make + " " + myCar.Model + " " + myCar.Colour);

			//Console.ReadLine();
			// ========================// ========================// ========================

			// ========================Visitor==========================

			//Man father = new Man();
			//father.children.Add(new Man());
			//father.children.Add(new Woman());

			//Man aunt = new Man();
			//aunt.children.Add(new Man());
			//aunt.children.Add(new Man());

			//Visitor visitor = new Visitor();
			//visitor.Process(father);
			//visitor.Process(aunt);

			//

			// ========================// ========================// ========================

			//var sb = new StringBuilder();
		}
	}

	#region Extentions methods
	// ======================== Паттерны методов расширения C# ==========================
	// класс для расширенных методов
	public static class ExtensionMethods
	{
		// метод совмещенных вызовов
		public static StringBuilder AppendFormatLine(this StringBuilder sb, string format, params object[] args)
		{
			return sb.AppendFormat(format, args).AppendLine();
		}

		// метоод добавления рекурсивных вызовов
		public static string PathCombine(this string[] paths)
		{
			var result = string.Empty;
			foreach (var path in paths)
			{
				result = Path.Combine(result, path);
			}
			return result;
		}

		// метод добавления множественных параметров
		public static void AddRange<T>(this IList<T> list, params T[] objects)
		{
			foreach (T obj in objects)
			{
				list.Add(obj);
			}
		}

		// перенос статического метода в метод расширения
		public static string F(this string format, params object[] args)
		{
			return string.Format(format, args);
		}

		// фабричные методы расширения
		public static DateTime June(this int day, int year)
		{
			return new DateTime(year, 6, day);
		}
	} 
	#endregion

	
	#region singleton
	// ======================== Singleton==========================
	class Singleton
	{
		private static Singleton _intstance = new Singleton();

		private Singleton() { }

		public static Singleton GetInstanse()
		{
			return _intstance;
		}
		public bool flag; // может быть любой член
	}
	// ========================// ========================// ========================
	#endregion
	

	// ======================== Factory Method==========================
	// Паттерн создания объектов. Предоставляет инструменты для создания экземпляров некоторого класса
	// При создании объекта наследники могут определить какого же класса создавать экземплят. 
	// ФАБРИКА предоставляет создание объектов наследникам базового класса. 
	// Это позволяет использовать в программе не конкретные классы, а манипулировать абст-ми объектами

	#region FactoryMethod reader 
	// данный класс могут наследовать другие
	public interface IReader
	{
		void readData(Object input);
	}

	// создадим три класса
	class ReaderDataBase : IReader
	{
		public void readData(object input)
		{
			throw new NotImplementedException();
		}
	}
	class ReaderTextFile : IReader
	{
		public void readData(object input)
		{
			throw new NotImplementedException();
		}
	}
	class ReaderBinaryFile : IReader
	{
		public void readData(object input)
		{
			throw new NotImplementedException();
		}
	}

	// для создания необходимого объекта (это и есть сам фабричный метод)
	class FactoryMethod
	{
		public IReader getCurrentReader(Object input)
		{
			if (input is ReaderDataBase)
			{
				return new ReaderDataBase();
			}
			else if (input is ReaderBinaryFile)
			{
				return new ReaderBinaryFile();
			}
			else
			{
				return new ReaderTextFile();
			}
		}
	} 
	#endregion

	#region FactoryMethod Car
	// немного другая реализация ФАБРИЧНОГО МЕТОДА
	interface ICreateCars
	{
		Car CreateACar(string colour);
	}
	class FordFiestaFactory : ICreateCars
	{
		public Car CreateACar(string colour)
		{
			return new FordFiesta() { Colour = colour };
		}
	}

	public abstract class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineSize { get; set; }
		public string Colour { get; set; }
	}

	public class FordFiesta : Car
	{
		public FordFiesta()
		{
			Make = "Ford";
			Model = "fiesta";
			EngineSize = "1.1";
		}
	} 
	#endregion

	// ======================== Visitor ==========================

	// есть какая то структура классов
	public abstract class Person
	{
		public IList<Person> children { get; set; }
	}
	public class Woman : Person
	{ 

	}
	public class Man : Person
	{ 
	}

	// а теперь сама реализация visitor
	public class Visitor
	{
		public void Process(Person person)
		{ 
			foreach (dynamic p in person.children)
			{
				Visit(p);
			}
		}
		void Visit(Man m)
		{ 
			Console.WriteLine("Visit man");
		}
		void Visit(Woman w)
		{
			Console.WriteLine("Visit woman");
		}
	}

	// ========================// ========================// ========================
}
