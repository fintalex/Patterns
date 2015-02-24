using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Pattern
{
	// Он инкапсулирует единственную функцию, сво-
	// бодную от каких бы то ни было переменных.
	public interface Command
	{
		void Execute();
		void Undo();
	}
	// И это уже является паттерном Команда
}
