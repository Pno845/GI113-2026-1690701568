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
            int sinnerLevel = 65;
            float defense = 61.5f;
            double attack = 52.2; 
            bool isPlayable = true;

            Console.WriteLine($"{GameTitle}");
            Console.WriteLine($"                                                    ████████████                                                   \r\n" +
                $"                                                ███████████████████                                                \r\n" +
                $"                                              ████████       █████████                                             \r\n" +
                $"                                             █████                █████                                            \r\n" +
                $"                                            ████                    ████                                           \r\n" +
                $"                                            ███                      ███                                           \r\n" +
                $"                                           ████                       ██                                           \r\n" +
                $"                                           ███       ███             ████                                          \r\n" +
                $"                                           ███       ███     █████   ████                                          \r\n" +
                $"                                           ████      █ █████ ██████  ███                                           \r\n" +
                $"                                            ███████ ███████████████ ████                                           \r\n" +
                $"                                             ██████████████████████████                                            \r\n" +
                $"                                              ███████████     ████████                                             \r\n" +
                $"                                                █████ ██       ██████                                              \r\n" +
                $"                                                  ████████████ ███                                                 \r\n" +
                $"                                               ██████████████████                                                  \r\n" +
                $"                                             ██████ █ █████ ███████                                                \r\n" +
                $"                                            █████ █ █ ████  █  ████                                                \r\n" +
                $"                                            ███        ███  ██   ███                                               \r\n" +
                $"                                            ██    █ █   ██  ██   ███                                               \r\n" +
                $"                                            ██   ███      █ ██    ███                                              \r\n" +
                $"                                            ██   █ █             ████                                              \r\n" +
                $"                                           ███   █ █ ██          ████                                              \r\n" +
                $"                                           ██   █ █ ███████      ██████                                            \r\n" +
                $"                                          ███   █ █ ████████████████████                                           \r\n" +
                $"                                         ███    █ ███   ████████████████                                           \r\n" +
                $"                                        ████    █ ██████████████████ ███                                           \r\n" +
                $"                                      █████       █   ██████  ██████████                                           \r\n" +
                $"                                     ████              █          █████                                            \r\n" +
                $"                                   █████                         ██████                                            \r\n" +
                $"                                 ██████                          █ █ ██                                            \r\n" +
                $"                               ██████    ███                         ██                                            \r\n" +
                $"                              █████      ███ █   █                   ██                                            \r\n" +
                $"                            █████       ████     █         █     █ █ ██                                            \r\n" +
                $"                            ████       ████    █ █         █     █   ██                                            \r\n" +
                $"                            ███████   █████    █ █         █     ██  ███                                           \r\n" +
                $"                              ██████████ ██    ███                   ███                                           \r\n" +
                $"                                  █████████     █                  █ ███                                           \r\n" +
                $"                                        ██    █ ████               █  ██                                           \r\n" +
                $"                                        ███   █  ███            ████████                                           \r\n" +
                $"                                        ████  █  ███            ████████                                           \r\n" +
                $"                                         █████  █ █            ███  ████                                           \r\n" +
                $"                                          ███████ █           ████  ████                                           \r\n" +
                $"                                            ███████          ████   ███                                            \r\n" +
                $"                                               ████         ████                                                   \r\n" +
                $"                                                 ███       ████                                                    \r\n" +
                $"                                                 ███      ████                                                     \r\n" +
                $"                                                 ███     ████                                                      \r\n" +
                $"                                                ████     ███                                                       \r\n" +
                $"                                                ███      ███                                                       \r\n" +
                $"                                                ███       ██                                                       \r\n" +
                $"                                                ████      ██                                                       \r\n" +
                $"                                                 ████ ██████                                                       \r\n" +
                $"                                                  ███ █   ███                                                      \r\n" +
                $"                                                  ███ ███ ███                                                      \r\n" +
                $"                                                   ██████████                                                      \r\n" +
                $"                                                                                                                   \r\n");

            Console.WriteLine($"Hero Name : {sinnerName}");
            Console.WriteLine($"Tier      : {sinnerTier}");
            Console.WriteLine($"Level     : {sinnerLevel}");
            Console.WriteLine($"Defense   : {defense}");
            Console.WriteLine($"Attack    : {attack}");
            Console.WriteLine($"Playable  : {isPlayable}");
            Console.WriteLine();

            double sinnerLevelAsDouble = sinnerLevel;
            Console.WriteLine($"Level as double (implicit): {sinnerLevelAsDouble}");

            int defensePower = (int)defense;               
            int attackPower = Convert.ToInt32(attack);      
            Console.WriteLine($"Defense cast (truncates)  : {defensePower}");
            Console.WriteLine($"Attack Convert (rounds)  : {attackPower}");
        }
    }
}
