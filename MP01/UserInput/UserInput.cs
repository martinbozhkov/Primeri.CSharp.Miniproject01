using System;
namespace UserInput
{
	public class UInput
	{
		About.Me about = new About.Me();
		Colors.ForCLI _c = new Colors.ForCLI();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary();

		public UInput()
		{
		}
		public void sayHello()
		{
			_c.Default(); Console.WriteLine("Добре дошли в " + about.shortName + " " + about.version + "\n");
		}
		public void getUserCommands()
		{
			string _command = "";
			do
			{
				//Взимане на команда
				_c.Prompt (); Console.Write("$ ");
				_c.Command (); _command = Console.ReadLine();

				//Проверка за налични команди
				if (_command.ToLower().Contains("яма")) _calc.F01.calc(_command);

				//if (_command.ToLower().Contains("Команда2")) Console.WriteLine("\nСтартирана е Команда 2\n");
				//if (_command.ToLower().Contains("Команда3")) Console.WriteLine("\nСтартирана е Команда 3\n");

			} while (_command.ToLower() != "изход");
		}
	}
}
