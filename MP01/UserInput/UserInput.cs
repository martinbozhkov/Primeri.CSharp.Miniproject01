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
			_c.Default();	Console.Write("Добре дошли в " + about.shortName + " " + about.version + "\n");
			_c.Result();	Console.WriteLine("Въведете параметъра [помощ], за да видите наличните команди.\n\n");
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
				if (_command.ToLower().Contains("яма") || _command.ToLower().Contains("въгъл") || _command.ToLower().Contains("иъгъл") 
				    || _command.ToLower().Contains("изход") || _command.ToLower().Contains("помощ") || _command.ToLower().Contains ("изчисти") || _command.Length < 1)
				{

					if (_command.ToLower().Contains("яма"))
						_calc.F01.calc(_command);

					if (_command.ToLower().Contains("въгъл"))
						_calc.F02.calc(_command);

					if (_command.ToLower().Contains("иъгъл"))
						_calc.F03.calc(_command);

					if (_command.ToLower().Contains("помощ") && _command.Length == 5)
					{ 
						_calc.commands(); 
					} else {
						
						if (_command.ToLower().Contains("помощ")) 
						{
							_c.Default(); Console.WriteLine("\nВъведете само параметъра 'помощ'.\n"); 
						}
					}

					if (_command.ToLower().Contains("изчисти") && _command.Length == 7)
					{
						Console.Clear();
						_c.Default(); Console.Write("Добре дошли в " + about.shortName + " " + about.version + "\n");
						_c.Result(); Console.WriteLine("Въведете параметъра [помощ], за да видите наличните команди.\n\n");
					}
					else {

						if (_command.ToLower().Contains("изчисти"))
						{
							_c.Default(); Console.WriteLine("\nВъведете само параметъра 'изчисти'.\n");
						}
					}

					if (_command.Length < 1)
					{
						_c.Default(); Console.WriteLine("\nС параметъра 'помощ' може да видите наличните команди.\n");
					}

				} else {
					
					_c.Default(); Console.WriteLine("\nИма грешно въведени параметри. С параметъра 'помощ' може да видите наличните команди.\n");
				}

			} while (_command.ToLower() != "изход");
			Console.WriteLine("");
		}
	}
}
