﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByDoFactory
{

	/// <summary>
	/// The 'Observer' interface
	/// </summary>
	interface IInvestor
	{
		void Update(Stock stock);
	}
}
