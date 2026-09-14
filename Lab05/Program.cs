namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===>BATTLE MODE<===");
            Console.WriteLine("Hero vs Villain -- Calculate Damage");

            //Hero Stats
            Console.Write("Hero HP: ");
            bool heroHpOK = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAttackOK = int.TryParse(Console.ReadLine(), out int heroAttack);
            Console.Write("Hero Defense: ");
            bool heroDefenseOK = int.TryParse(Console.ReadLine(), out int heroDefense);

            //Villain Stats
            Console.Write("\nVillain HP: ");
            bool villainHpOK = int.TryParse(Console.ReadLine(), out int villainHp);
            Console.Write("Villain Attack: ");
            bool villainAttackOK = int.TryParse(Console.ReadLine(), out int villainAttack);
            Console.Write("Villain Defense: ");
            bool villainDefenseOK = int.TryParse(Console.ReadLine(), out int villainDefense);

            //Check if all inputs are valid
            bool heroInputVaild = heroHpOK && heroAttackOK && heroDefenseOK;
            bool villainInputVaild = villainHpOK && villainAttackOK && villainDefenseOK;
            Console.WriteLine($"Hero stats vaild: {heroInputVaild}");
            Console.WriteLine($"Villain stats vaild: {villainInputVaild}");
            Console.WriteLine($"[HERO     | HP: {heroHp} | ATTACK: {heroAttack} | DEFENSE: {heroDefense}]");
            Console.WriteLine($"[VILLAIN  | HP: {villainHp} | ATTACK: {villainAttack} | DEFENSE: {villainDefense}]");

            //Hero drinks potion before battle (composite assignment: +=)
            int potionHeal = 20;
            //heroHp = heroHp + potionHeal; ผลคือ 120
            //heroHP += potionHeal; ผลคือ 120
            heroHp += potionHeal; //Hero ดืม HP potionHeal
            Console.WriteLine($"Hero drinks a potion, healing {potionHeal} HP, Hero HP is: {heroHp}");

            int normalDamage = Math.Max(0, heroAttack - villainDefense); //โจมตีปกติ โดยการ -
            Console.WriteLine($"Normal attack deals: {normalDamage} DMG");

            int powerDamage = Math.Max(0, heroAttack * 2 - villainDefense); //โจมตีแบบพลัง โดยการ *
            Console.WriteLine($"Power attack deals: {powerDamage} DMG");

            int counterDamage = Math.Max(0, villainAttack - heroDefense); //โจมตีสวนกลับ ไม่ต้องเปลี่ยนสูตร
            Console.WriteLine($"Counter attack deals: {counterDamage} DMG");

            Random randomCrit = new Random();
            int rollchance = randomCrit.Next(1, 101); // สุ่มตัวเลข 1-100 หรือค่าอื่นๆต้ิง +1
            bool isCrit = rollchance <= 30; //30% chance to crit   
            int CritDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // ได้ค่า 1 หรือ 0 เป็นตัวกําหนดว่าจะได้รับ Crit Damage หรือไม่
            Console.WriteLine($"Critical Damage roll:{rollchance} (Critical?: {isCrit})");
            Console.WriteLine($"If critical, normal attack would deal: {CritDamage} DMG");
        }
    }
}
