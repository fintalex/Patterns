﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			var remote = new RemoteControl();
			string userInput;

			do
			{
				remote.DrawMenu();
				remote.PerformAction();

				Console.WriteLine("\nВы хотите продолжить (y/n): ");
				userInput = Console.ReadLine();
			} while (userInput != "y");
		}
	}
}
