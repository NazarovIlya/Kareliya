using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Net.Http.Json;
namespace KareliyaBS.Data
{
	public class Randomize
	{
		public static int Page()
		{
			Random rnd = new Random();
			int random = rnd.Next(0, 3);
			return random;
		}
	}
}