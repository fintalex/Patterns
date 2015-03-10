using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.WildCats
{
	interface IWildCat
	{
		string Breed { get; }
		void Growl();
		void Scratch();
	}
}
