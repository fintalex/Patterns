using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Parts
{
	public class BlackPaint : Paint
	{
		public BlackPaint()
		{
			Console.WriteLine("Paint is black");
		}
	}
}
