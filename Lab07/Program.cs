/*
* Student ID : 1690701568
* Name       : Sattarin Saelao
* Section    : 129B
* No.        : 26
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab07 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int command = 0;

            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y" || answer == "yes")

            switch (answer)
            {
                case "y":
                case "Y":
                case "yes":
                    Console.WriteLine("Hero escaped!"); //ใส่การทํางานโค้ดที่นี่
                    break; //ไม่มี break จะทําให้โปรแกรมทํางานต่อไปยัง case ต่อไป
                default:
                    Console.WriteLine("invalid command!"); //ใส่การทํางานโค้ด เมื่อไม่ตรงกัน case ใดๆ
                    break;
            }*/



            /*int classId = 2;

            string weapon = classId switch
            {
                1 => "Sword",
                2 => "Bow",
                3 => "Staff",
                _ => "Fists"
            };*/



            /*int hp=-5;
            string healthStatus = hp switch
            {
                >= 100 => "Full Health",
                > 0 => "Health not full",
                <= 0 => "Dead"
            };
            Console.WriteLine($"Health Status: {healthStatus}"  );*/



            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");

            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Rain of Arrow");
            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                case 5:
                    Console.WriteLine("Hero summons a Rain of Arrow!");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }

            int power = command switch
            {
                1 => 12,
                2 => 18,
                5 => 25,
                _ => 0
            };
            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            string rating = damage switch
            {
                >= 20 => "Fatal Damage",
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");

            string monsterStatus = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");

            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
        }
    }
}
