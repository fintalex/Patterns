using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonostatePattern
{
	//Каким образом два экземпляра могут вести себя так, будто это един-
	//ственный объект? Да просто это означает, что у них одни и те же
	//переменные-члены. 

	//Сколь-
	//ко бы экземпляров класса Monostate ни создать, все они ведут себя так,
	//как будто являются одним и тем же объектом. Можно даже уничто-
	//жить все текущие экземпляры, не потеряв при этом данных.
	public class Monostate
	{
		private static int itsX;

		public int X 
		{
			get { return itsX; }
			set { itsX = value; }
		}
	}
}
