using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
	class Program
	{
		static void Main(string[] args)
		{
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
			var factory = new FordFiestaFactory() as ICreateCars;

			var myCar = factory.CreateACar("red");

			Console.WriteLine("Make: " + myCar.Make + " " + myCar.Model + " " + myCar.Colour);

			Console.ReadLine();
			// ========================// ========================// ========================
		}
	}

	// ======================== Singleton==========================
	#region singleton
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
	#endregion
	// ========================// ========================// ========================

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
}
