using System;
namespace Calculations
{
	public	 class Formula01
	{
		//Библиотеки

		private Colors.ForCLI _c = new Colors.ForCLI();

		public Formula01() //Формула за обикновена строителна яма
		{
		}

		//Парсване	
		public void calc(string _userInput)
		{
			try
			{
				string[] param = _userInput.Split(' ');

				if (param.Length > 1 && _userInput.Contains("-п"))
				{
					//Помощ за командата
					help();
				}

				if (param.Length > 1 && !_userInput.Contains("-п"))
				{
					//Изчисления
					double _result = 0;

					if (runCalculations(param, out _result))
					{
						_c.Default(); Console.Write("\nОбема на строителната яма е: ");
						_c.Result(); Console.Write(_result.ToString("N2"));
						_c.Default(); Console.WriteLine(" м3\n");
					}
					else {
						_c.Default(); Console.WriteLine("\nИма грешно въведени параметри. \nС параметъра '-п' можете да видите синтаксиса на командата\n");
					}

				}

				if (param.Length > 0 && param.Length < 2 && _userInput.ToLower().Contains("яма"))
				{
					_c.Default(); Console.WriteLine("\nИма грешно въведени параметри. \nС параметъра '-п' можете да видите синтаксиса на командата\n");
				}

			}catch{
			}
		}

		//Изчисления и изписване

		private bool runCalculations(string[] param, out double _result)
		{
			try
			{
				double _a1 = 0, _b1 = 0, _a2 = 0, _b2 = 0, _h = 0;
				Double.TryParse(param[1], out _a1);
				Double.TryParse(param[2], out _b1);
				Double.TryParse(param[3], out _a2);
				Double.TryParse(param[4], out _b2);
				Double.TryParse(param[5], out _h);

				double F1 = _a1 * _b1, F2 = _a2 * _b2;
				_result = _h * (F1 + F2) / 2;

				return true;

			}
			catch
			{
			}
			_result = 0;
			return false;
		}

		//Помощ за командата
		private void help()
		{
			_c.Result(); Console.Write("\n[Яма]");
			_c.Default(); Console.WriteLine(" - команда за пресмятане на строителна яма\n");

			_c.Command(); Console.Write("параметри: ");
			_c.Default(); Console.WriteLine("a1 b1 a2 b2 h\n");

			_c.Command(); Console.Write("a1 и b1");
			_c.Default(); Console.WriteLine(" - ширина и дължина на горната страна на изкопа");

			_c.Command(); Console.Write("a2 и b2");
			_c.Default(); Console.WriteLine(" - ширина и дължина на долната страна на изкопа");

			_c.Command(); Console.Write("h ");
			_c.Default(); Console.WriteLine("- височина на изкопа\n");
		}
	}
}

