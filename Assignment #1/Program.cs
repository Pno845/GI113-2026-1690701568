/*
* Student ID : 1690701568
* Name       : Sattarin Saelao
* Section    : 129B
* No.        :
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle =
                "============================================================================ \r\n" +
                "█     █ █   █ ████  █   █  ████     ███   ███  █   █ ████   ███  █   █ █   █ \r\n" +
                "█     █ ██ ██ █   █ █   █ █        █     █   █ ██ ██ █   █ █   █ ██  █  █ █  \r\n" +
                "█     █ █ █ █ ████  █   █  ███     █     █   █ █ █ █ ████  █████ █ █ █   █   \r\n" +
                "█     █ █   █ █   █ █   █     █    █     █   █ █   █ █     █   █ █  ██   █   \r\n" +
                "█████ █ █   █ ████   ███  ████      ███   ███  █   █ █     █   █ █   █   █   \r\n" +
                "============================================================================ \r\n" +
                "";

            var sinnerName = "Yi Sang";
            var sinnerTier = 'O';
            int sinnerHp = 109;
            int sinnerSpeed = 5;
            int sinnerLevel = 15;
            float defense = 13.2f;
            double attack = 15.4;
            bool isBackup = true;
            double slashResistance = 2;
            double pieceResistance = 0.5;
            double bluntResistance = 1;

            Console.WriteLine($"{GameTitle}");
            Console.WriteLine(
                $"                                                            \r\n" +
                $"                          =%@@@@#*.                         \r\n" +
                $"                        *@%@%%%%%%@#.                       \r\n" +
                $"                       =@%%%%#%%%#%%@                       \r\n" +
                $"                       *@@%%#%%%%%%@*:                      \r\n" +
                $"                       =@@%@-%=@#=%@#                       \r\n" +
                $"                        -=%==-..--*#                        \r\n" +
                $"                          ::......=                         \r\n" +
                $"                          :%+%%#                            \r\n" +
                $"                       .%%*#%=*%%@:                         \r\n" +
                $"                       -%%%%@#*#%%#                         \r\n" +
                $"                       +%%*%@%##%%#.                        \r\n" +
                $"                       %%##%%%%#%@#=                        \r\n" +
                $"                      =%%##-.:%%.+:++                       \r\n" +
                $"                     =%%@%%@#%%@@=-+-                       \r\n" +
                $"                    #%%@%%%%%%%%@%%@:                       \r\n" +
                $"                  *%%%@@%#%%%%%@@%%%=                       \r\n" +
                $"                =#%%##*%%#%%%%#@@@%%=                       \r\n" +
                $"               #%%### %%%#@%%%#@@@%#+                       \r\n" +
                $"                 .=# :#%##@%%%#@@@%%#                       \r\n" +
                $"                     +%%*%%%%%%@@@%%%                       \r\n" +
                $"                      ##*#*%%@%@@%  %                       \r\n" +
                $"                       :#*#%%%%@@=  +                       \r\n" +
                $"                         .#%%%%@:                           \r\n" +
                $"                          *%%@@.                            \r\n" +
                $"                          %%@@#                             \r\n" +
                $"                         =@%@@#                             \r\n" +
                $"                          -%%@@                             \r\n" +
                $"                           @##@                             \r\n" +
                $"                            ...                             \r\n");

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"|   Sinner    : {sinnerName}         |"); 
            Console.WriteLine($"|   Tier      : {sinnerTier}               |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"|          ==Stats==            |");
            Console.WriteLine($"|   Level     : {sinnerLevel}              |");
            Console.WriteLine($"|   HP        : {sinnerHp}             |");
            Console.WriteLine($"|   Speed     : {sinnerSpeed}               |");
            Console.WriteLine($"|   Defense   : {defense}            |");
            Console.WriteLine($"|   Attack    : {attack}            |");
            Console.WriteLine($"|   Backup    : {isBackup}            |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"|        ==Resistance==         |");
            Console.WriteLine($"|   Slash Resistance : (x{slashResistance})     |");
            Console.WriteLine($"|   Piece Resistance : (x{pieceResistance})   |");
            Console.WriteLine($"|   Blunt Resistance : (x{bluntResistance})     |");

            Console.WriteLine("---------------------------------");
            double sinnerLevelAsDouble = sinnerLevel;
            Console.WriteLine($"|   Level : {sinnerLevelAsDouble}                  |");
            int defensePower = (int)defense;               
            int attackPower = Convert.ToInt32(attack);      
            Console.WriteLine($"|   Defense Skill  : {defensePower}         |");
            Console.WriteLine($"|   Attack Skill   : {attackPower}         |");
            Console.WriteLine("---------------------------------");
        }
    }
}
