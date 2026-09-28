/*
* Student ID : 1690701568
* Name       : Sattarin Saelao
* Section    : 129B
* No.        : 26
* Course     : GI113 Computer Programming (GI)
*/


using System.ComponentModel.Design;

namespace Assisment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mode = 0;

            const string ore = "Gold";
            const double smeltRate = 0.2500;
            const double salvageRate = 0.3000;
            const int maxBatch = 100;

            Console.WriteLine("-----------------------------------\r\n--     Welcome to the Forge      --\r\n-----------------------------------");
            Console.WriteLine("Want Smelt Gold? (Ore > Bar)");
            Console.WriteLine("Want Breakdown Gold Bar? (Bar > Ore)");
            Console.Write("Choose The Choice (S or B): ");
            string isChoose = Console.ReadLine();
            Console.WriteLine();

            if (isChoose == "s" || isChoose == "S")
            {
                Console.WriteLine("Start Smelt");
                mode = 0;
            }
                else if (isChoose == "b" || isChoose == "B")
            {
                Console.WriteLine("Start Breakdown");
                mode = 1;         
            }
            else
            {
                mode = 2;
            }
            
            if (mode == 0)
            {
                Console.Write("How much would you like: ");
                bool inNumber = int.TryParse(Console.ReadLine(), out int amount);
                if (!inNumber || amount > 0 && amount <= 100)
                {
                    Console.Write($"{amount * smeltRate} Gold Bar");
                }
                else
                {
                    Console.Write("Error:amount");
                }
            }
            else if (mode == 1)
            {
                Console.Write("How much would you like: ");
                bool inNumber = int.TryParse(Console.ReadLine(), out int amount);
                if (!inNumber || amount > 0 && amount <= 100)
                {
                    Console.Write($"{amount * salvageRate} Gold Ore");
                }
                else
                {
                    Console.Write("Error:amount");
                }
            }
            else
            {
                Console.WriteLine("Error:menu");
            }    
        }
    }
}
