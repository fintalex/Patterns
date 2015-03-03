using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
	//Рассмотрим следующий код:
	//Employee e = DB.GetEmployee(“Bob”);
	//if (e != null && e.IsTimeToPay(today))
	// e.Pay();

	//Все мы писали такой код. Эта идиома стала привычной, потому что
	//в языках, ведущих происхождение от C, сначала вычисляется первый
	//член выражения &&, а второй – только в случае, когда первый равен
	//true. Многие программисты обжигались, забыв включить проверку на
	//null. Но какой бы распространенной ни была эта идиома, она некрасива
	//и провоцирует ошибки.
	public class NullObject
	{
	}
}
