using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            HockeyManager manager = new HockeyManager();

            manager.AddNewForward("Ján Šťastný", 25, 30);
            manager.AddNewDefender("Peter Zelený", 27, 50);
            manager.AddNewGoalie("Štefan Špekulant", 23, 15);

            manager.PrintNameAndAgeOfTheYoungestPlayer();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
