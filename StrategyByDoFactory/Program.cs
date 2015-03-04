using System;

//У нас есть абстрактный класс от которого наследуются различные реализации, сколько угодно
// и добавлять мы их можем очень гибко
// главное что в базовом абстрактном классе у нас есть метод абстрактный, 
// которые должны будут реализовывать остальные подклассы ( в прошлом варианте-это была реализация пузырьковой сортировки)
// Зачем нужен контекст?
// Класс контекст, я так понимаю, нужен для управления всей этой стретагией.
// Создаем экземпляр класса контекст, но мы не можем его создать не прокунив туда
// определенный класс стратегии (так сказать, указать способ реализации нашей стратегии)
// после чего, когда в нашем созданном экземпляре класса будет сидеть определенная стратегия - 
// ссылка на объект(ConcreteStrategyA,ConcreteStrategyB, ConcreteStrategyC)
// то мы уже можем запускать метод контекста, который в свою очередь, запускает выполнение стратегии. 
// И ему пофиг как реализована эта стратегия 
namespace DoFactory.GangOfFour.Strategy.Structural
{
	/// <summary>
	/// MainApp startup class for Structural
	/// Strategy Design Pattern.
	/// </summary>
	class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		static void Main()
		{
			Context context;

			// Three contexts following different strategies
			context = new Context(new ConcreteStrategyA());
			context.ContextInterface();

			context = new Context(new ConcreteStrategyB());
			context.ContextInterface();

			context = new Context(new ConcreteStrategyC());
			context.ContextInterface();

			// Wait for user
			Console.ReadKey();
		}
	}

	/// <summary>
	/// The 'Strategy' abstract class
	/// </summary>
	abstract class Strategy
	{
		public abstract void AlgorithmInterface();
	}

	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	class ConcreteStrategyA : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine(
			  "Called ConcreteStrategyA.AlgorithmInterface()");
		}
	}

	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	class ConcreteStrategyB : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine(
			  "Called ConcreteStrategyB.AlgorithmInterface()");
		}
	}

	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	class ConcreteStrategyC : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine(
			  "Called ConcreteStrategyC.AlgorithmInterface()");
		}
	}

	/// <summary>
	/// The 'Context' class
	/// </summary>
	class Context
	{
		private Strategy _strategy;

		// Constructor
		public Context(Strategy strategy)
		{
			this._strategy = strategy;
		}

		public void ContextInterface()
		{
			_strategy.AlgorithmInterface();
		}
	}
}


