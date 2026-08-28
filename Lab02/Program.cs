/*
 * Student ID : 1690701568
 * Name       : Sattarin Saelao
 * Section    : 129B
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part A Lab02
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercent}");
            Console.WriteLine();

            Console.WriteLine($"Kirin take 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercent}");

            // โครงพิมพ์ผล 1 ตัวละคร (ปรับ label ตามธีมของตัวเอง)
            // Console.WriteLine($"Name: {name}");
            // Console.WriteLine($"HP: {hp}");
            // Console.WriteLine($"Speed: {speed}");
            // ทำซ้ำแบบนี้ให้ครบ 4 ตัวละคร ตัวละ 5 stat

            //Part B Lab02

        }
    }
}
