using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
	public class Goalie : Player
	{
		public int Wins { get; set; }
		public Goalie(string name, int age, int wins) : base(name, age)
		{

			Wins = wins;

		}
	}
}
