using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void PlayerInfoDel();
        //
        public delegate void PlayerInfoWithNameDel(string playerName);
        //
        public delegate void PlayerInfoNameWithGoalsDel(string name, int goals);
        //
        public delegate string PlayerBasedOnNumber(int number);
        static void Main(string[] args)
        {
            PlayerInfoDel ronaldinho = new PlayerInfoDel(DisplayInformation);
            ronaldinho();

            PlayerInfoWithNameDel playerName = new PlayerInfoWithNameDel(DisplayInformation);
            playerName("Messi");

            PlayerInfoNameWithGoalsDel newPlayer = new PlayerInfoNameWithGoalsDel(DisplayInformation);
            newPlayer("Ronaldo", 60);
            newPlayer("Rooney", 25);

            PlayerBasedOnNumber number = new PlayerBasedOnNumber(DisplayInformation);
            Console.WriteLine(number(8));
            Console.WriteLine(number(10));
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Information about player : Ronaldinho from brazil");
        }

        public static void DisplayInformation(string playName)
        {
            Console.WriteLine("Information about player : "+ playName);
        }

        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about player : " + playerName + "and he score " + goals);
        }

        public static string DisplayInformation(int number)
        {
            string playerName = string.Empty;
            switch (number)
            {
                case 7: playerName = "Ronaldo"; break;
                case 8: playerName = "Iniesta"; break;
                case 10: playerName = "Messi"; break;
            }
            return playerName;
        }
    }
}
