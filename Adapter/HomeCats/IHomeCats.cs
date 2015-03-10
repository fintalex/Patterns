using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeCats
{
	interface IHomeCats
	{
		string Name { get; set; }
		void Meow();
		void Scratch();
	}
}
