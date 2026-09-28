/*
* Student ID : 1690701568
* Name       : Sattarin Saelao
* Section    : 129B
* No.        : 26
* Course     : GI113 Computer Programming (GI)
*/

using System.Runtime.InteropServices;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bool isPoisioned = false;
            if (isPoisioned) { } //ไม่จริง เพราะเป็นการเซ็ตค่าเป็น false
            if (!isPoisioned) { } //จริง เพราะเป็นการเช็คว่าไม่เป็นพิษ

            bool hasKey = false;
            Console.WriteLine("Your Level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int level);
            if (!ok || level <1 || level > 99)
            {
                Console.WriteLine("Invalid level");
            }
            if (level >= 10 || hasKey)
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                if (hasKey)
                {
                    Console.WriteLine("The door opens.");
                }
                else if (!hasKey)
                {
                    Console.WriteLine("Locked.");
                }
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }

            int score = 85;
            if (score >= 90)
            {
                Console.WriteLine("Rank S!");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Rank A!");
            }
            else
            {
                Console.WriteLine("Rank B!");
            }*/

            bool battle = false;
            int yiSangHP = 109;
            int yiSangATK = 26;
            int leiHengHP = 310;
            int leiHengATK = 46;
            Console.WriteLine("====== Limbus Company ======");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Yi sang HP: " + yiSangHP);
            Console.WriteLine("Yi sang ATK: " + yiSangATK);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Yi sang encounter Lei heng (Hiden Boss)");
            Console.WriteLine("Choice 1: Encounter");
            Console.WriteLine("Choice 2: Skip");
            Console.WriteLine();

            Console.Write("Choose The Choice (1-2): ");
            bool isInPutValid = int.TryParse(Console.ReadLine(), out int choice);
            if (!isInPutValid || choice < 1 || choice > 2)
            {
                Console.WriteLine("Invalid choice");
            }
                else if (choice == 1)
                {
                    Console.WriteLine("Yi sang encounter Lei heng and start the battle!");
                    battle = true;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Yi sang skip the encounter and continue MirrorDungeon.");
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

            if (battle)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Lei heng HP: " + leiHengHP);
                Console.WriteLine("Lei heng ATK: " + leiHengATK);
                Console.WriteLine("----------------------------");
                Console.Write("Yi sang have to Clash with Lei heng (ClashPower 12) [5-15]: ");
                bool inputValid = int.TryParse(Console.ReadLine(), out int clash);
                if (!inputValid || clash < 5 || clash > 15)
                {
                    Console.WriteLine("Invalid clash number");
                }
                else if (clash <= 11)
                {
                    Console.WriteLine("Yi sang take damage.");
                    int yisangHP = Math.Max(0, yiSangHP - leiHengATK);
                    Console.WriteLine($"Yi sang HP: {yisangHP}");
                }
                else if (clash >= 12)
                {
                    Console.WriteLine("Yi sang deal damage to Lei heng.");
                    int leihengHP = Math.Max(0, leiHengHP - yiSangATK);
                    Console.WriteLine($"Lei heng HP: {leihengHP}");
                }
                else
                {
                    Console.WriteLine("Invalid clash number");
                }

            }
        }
    }
}
