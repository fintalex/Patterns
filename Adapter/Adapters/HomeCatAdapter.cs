using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.HomeCats;
using Adapter.WildCats;

namespace Adapter.Adapters
{
	class HomeCatAdapter : IHomeCats
	{
		private IWildCat _wildCat;

		public HomeCatAdapter(IWildCat wildCat)
		{
			_wildCat = wildCat;
		}
		public string Name
		{
			get { return _wildCat.Breed; }
			set { }
		}

		public void Meow()
		{
			_wildCat.Growl();
		}

		public void Scratch()
		{
			_wildCat.Scratch();
		}
	}
}
