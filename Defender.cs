using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
	public class Defender : Player
	{
		public int Hits { get; set; }
		public Defender(string name, int age, int hits) : base(name, age)
		{

			Hits = hits;

		}
	}
}
