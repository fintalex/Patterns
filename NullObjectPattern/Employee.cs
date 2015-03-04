using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObjectPattern
{
	public abstract	class Employee
	{
		public abstract bool IsTimeToPay(DateTime time);
		public abstract void Pay();
		// статическая переменная для хранения единственного экземпляра закрытого вложенного класса NullEmployy
		// в котором переопределенные абстрактные методы не делают ничего - может это недостаток, конечно
		public static readonly Employee NULL = new NullEmployee();
		
		// подкласс для Null объекта
		// обязательно закрытый вложенный класс - гарантирует единственность экземпляра
		private class NullEmployee : Employee
		{
			public override bool IsTimeToPay(DateTime time)
			{
				return false;
			}
			public override void Pay()
			{
				
			}
		}
	}
	
}
