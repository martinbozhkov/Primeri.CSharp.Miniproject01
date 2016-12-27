using System;
namespace Calculations
{
	public class MainLibrary
	{
		//Дефиниции
		public Formula01 F01 = new Formula01();
		public Formula02 F02 = new Formula02();
		public Formula03 F03 = new Formula03();

		//Библиотеки
		private Colors.ForCLI _c = new Colors.ForCLI();

		public MainLibrary()
		{
		}

		public void commands()
		{
			_c.Default(); Console.WriteLine("\nНалични команди: \n");

			_c.Command(); Console.Write("[яма]");
			_c.Default(); Console.WriteLine(" - пресмятане на строителна яма");

			_c.Command(); Console.Write("[въгъл]");
			_c.Default(); Console.WriteLine(" - пресмятане на вдлъбнат ъгъл");

			_c.Command(); Console.Write("[яма]");
			_c.Default(); Console.WriteLine(" - пресмятане на изпъкнал ъгъл\n");

			_c.Command(); Console.Write("[помощ]");
			_c.Default(); Console.WriteLine(" - показва наличните команди\n");

			_c.Command(); Console.Write("[изчисти]");
			_c.Default(); Console.WriteLine(" - изчиства направените до сега изчисления\n");

		}
	}
}
