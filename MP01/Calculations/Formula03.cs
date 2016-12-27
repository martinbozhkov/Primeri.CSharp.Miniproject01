using System;
namespace Calculations
{
	public class Formula03
	{
		private Colors.ForCLI _c = new Colors.ForCLI();

		public Formula03()
		{
		}

		public void calc(string _input)
		{
			try
			{
				string[] param = _input.Split(' ');

				if (param.Length > 1 && _input.ToLower().Contains("-п"))
				{
					help();
				}

				if (param.Length == 4)
				{
					double _result = 0;

					if (runCalculate(param, out _result))
					{
						_c.Default(); 	Console.Write("\nОбемът на изпъкналия ъгъл е ");
						_c.Result(); 	Console.Write(_result.ToString("N2"));
						_c.Default(); 	Console.WriteLine(" m3\n");

					}

				} else {
					
					if (param.Length >= 2 && _input.ToLower().Contains("иъгъл"))
					{
						_c.Default(); Console.WriteLine("\nИма грешно въведени параметри. \nС параметъра '-п' можете да видите синтаксиса на командата\n");
					}
				}

				if (param.Length > 0 && param.Length < 2 && _input.ToLower().Contains("иъгъл"))
				{
					_c.Default(); Console.WriteLine("\nИма грешно въведени параметри. \nС параметъра '-п' можете да видите синтаксиса на командата\n");
				}

			} catch {
			}
		}

		private bool runCalculate(string[] param, out double _result)
		{
			try
			{
				//param[0] --> ковандата "въгъл"
				double a = 0; Double.TryParse(param[1], out a);
				double b = 0; Double.TryParse(param[2], out b);
				double h = 0; Double.TryParse(param[3], out h);

				_result = 2 * a * b * h / 3;

				return true;
			}
			catch
			{
			}

			_result = 0;
			return false;
		}


		private void help()
		{
			_c.Result(); Console.Write("\n[иъгъл]");
			_c.Default(); Console.WriteLine(" - изпъкнал ъгъл");

			_c.Command(); Console.Write("\nпараметри: ");
			_c.Default(); Console.WriteLine("a b h");

			_c.Command(); Console.Write("\na и b");
			_c.Default(); Console.WriteLine(" - ширина и дължина");

			_c.Command(); Console.Write("h");
			_c.Default(); Console.WriteLine(" - височина\n");
		}
	}
}
