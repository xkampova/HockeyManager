using System;
using System.Collections.Generic;
using System.Linq;

namespace HockeyManager { 
	public class HockeyManager
	{

		public HockeyManager()
		{
		}
		private List<Player> players = new List<Player>();
		public void AddNewForward(string name, int age, int goals)
		{
			players.Add(new Forward(name, age, goals));
		}
		public void AddNewDefender(string name, int age, int hits)
		{
			players.Add(new Defender(name, age, hits));
		}
		public void AddNewGoalie(string name, int age, int wins)
		{
			players.Add(new Goalie(name, age, wins));
		}
		public void PrintNameAndAgeOfTheYoungestPlayer()
		{
			Player youngestPlayer = players.OrderBy(player => player.Age).First();
			Console.WriteLine($"Youngest Player: {youngestPlayer.Name}, Age: {youngestPlayer.Age}");

		}
	
	}
}



