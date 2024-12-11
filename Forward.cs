using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
	public class Forward : Player
	{
		public int Goals { get; set; }
		public Forward(string name, int age, int goals) : base(name, age)
		{

			Goals = goals;

		}
	}

}
