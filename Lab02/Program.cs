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
            Console.WriteLine();

            // โครงพิมพ์ผล 1 ตัวละคร (ปรับ label ตามธีมของตัวเอง)
            // Console.WriteLine($"Name: {name}");
            // Console.WriteLine($"HP: {hp}");
            // Console.WriteLine($"Speed: {speed}");
            // ทำซ้ำแบบนี้ให้ครบ 4 ตัวละคร ตัวละ 5 stat

            //Part B Lab02
            Console.WriteLine("===== CHARACTER STATUS: INITIAL =====");
            string characterName1 = "Archer";
            string characterClass1 = "Ranger";
            char rank1 = 'A';
            int speeed1 = 20;
            int maxHp1 = 120;
            int defense1 = 10;
            int currentHp1 = 120;
            float attackPower1 = 30.0f;
            double critMultiplier1 = 2.0;
            int critChance1 = 40;
            bool isAlive1 = true;
            Console.WriteLine($"Name: {characterName1}");
            Console.WriteLine($"Class: {characterClass1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"HP: {currentHp1} / {maxHp1}");
            Console.WriteLine($"Defense: {defense1}");
            Console.WriteLine($"Attack Power: {attackPower1}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier1}");
            Console.WriteLine($"Speed: {speeed1}");
            Console.WriteLine($"Critical Rate: {critChance1}%");
            Console.WriteLine($"Is Alive: {isAlive1}");
            Console.WriteLine();

            string characterName2 = "Gregor";
            string characterClass2 = "Tanker";
            char rank2 = 'B';
            int speeed2 = 10;
            int maxHp2 = 250;
            int currentHp2 = 230;
            int defense2 = 25;
            float attackPower2 = 17.5f;
            double critMultiplier2 = 1.35;
            int critChance2 = 15;
            bool isAlive2 = true;
            Console.WriteLine($"Name: {characterName2}");
            Console.WriteLine($"Class: {characterClass2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"HP: {currentHp2} / {maxHp2}");
            Console.WriteLine($"Defense: {defense2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier2}");
            Console.WriteLine($"Speed: {speeed2}");
            Console.WriteLine($"Critical Rate: {critChance2}%");
            Console.WriteLine($"Is Alive: {isAlive2}");
            Console.WriteLine();

            string characterName3 = "Kali";
            string characterClass3 = "Witch";
            char rank3 = 'A';
            int speeed3 = 14;
            int maxHp3 = 150;
            int currentHp3 = 150;
            int defense3 = 12;
            float attackPower3 = 45.0f;
            double critMultiplier3 = 1.4;
            int critChance3 = 25;
            bool isAlive3 = true;
            Console.WriteLine($"Name: {characterName3}");
            Console.WriteLine($"Class: {characterClass3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"HP: {currentHp3} / {maxHp3}");
            Console.WriteLine($"Defense: {defense3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier3}");
            Console.WriteLine($"Speed: {speeed3}");
            Console.WriteLine($"Critical Rate: {critChance3}%");
            Console.WriteLine($"Is Alive: {isAlive3}");
            Console.WriteLine();

            string characterName4 = "Luna";
            string characterClass4 = "Healer";
            char rank4 = 'S';
            int speeed4 = 12;
            int maxHp4 = 180;
            int currentHp4 = 180;
            int defense4 = 15;
            float attackPower4 = 15.0f;
            double critMultiplier4 = 1.2;
            int critChance4 = 15;
            bool isAlive4 = true;
            Console.WriteLine($"Name: {characterName4}");
            Console.WriteLine($"Class: {characterClass4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"HP: {currentHp4} / {maxHp4}");
            Console.WriteLine($"Defense: {defense4}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier4}");
            Console.WriteLine($"Speed: {speeed4}");
            Console.WriteLine($"Critical Rate: {critChance4}%");
            Console.WriteLine($"Is Alive: {isAlive4}");
        }
    }
}
