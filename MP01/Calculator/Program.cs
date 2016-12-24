using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотеки
		public UserInput.UInput uInput = new UserInput.UInput();
		public About.Me about = new About.Me();

		public static void Main(string[] args)
		{
			//Предефиниране на MainClass
			MainClass _program = new MainClass();

			//Форматиране на програма
			Console.Title = _program.about.shortName + ", " + _program.about.version;

			//Стартиране на програма
			_program.uInput.sayHello();
			_program.uInput.getUserCommands();
		}
	}
}

