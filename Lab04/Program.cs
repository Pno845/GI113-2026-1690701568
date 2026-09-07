namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("+-------------------------+"); 
            //Console.WriteLine("|      NEW ADVENTURE      |");
            //Console.WriteLine("+-------------------------+"); // Title, WriteLine คือการพิมพ์แล้วขึ้นบรรทัดใหม่

            //Console.Write("Name your hero: "); // Write คือการพิมพิ์ต่อบรนทัดเดิม
            //string playerName = Console.ReadLine(); //Read.ine() คือการรับค่าจากผู้ใช้ (เป็นข้อความ, string)

            //Console.WriteLine($"\nWelcome, {playerName}! Your journey begins.");

            //Console.WriteLine("+-------------------------+");
            //Console.WriteLine("|    DIFFICULTY SELECT    |");
            //Console.WriteLine("+-------------------------+");
            //Console.Write("Choose difficulty (1-3): ");
            //int difficulty = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Difficulty set to {difficulty}.");

            //Console.WriteLine("+-------------------------+");
            //Console.WriteLine("|        ITEM SHOP        |");
            //Console.WriteLine("+-------------------------+");
            //Console.Write("How many potions? ");
            //bool isVaild = int.TryParse(Console.ReadLine(), out int quantity);
            //Console.WriteLine($"Valid input: {isVaild}");
            //Console.WriteLine($"Quantity: {quantity}");

            //Console.WriteLine("+-------------------------+");
            //Console.WriteLine("|     RATE THIS LEVEL     |");
            //Console.WriteLine("+-------------------------+");
            //Console.Write("Rate this level (0.0 - 5.0): ");
            //bool isValid = double.TryParse(Console.ReadLine(), out double rating);
            //Console.WriteLine($"Valid input: {isValid}");
            //Console.WriteLine($"Rating: {rating}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION      |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-5): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          ITEM  SHOP          |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool isVaild = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isVaild}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET  VOLUME         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE        |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
