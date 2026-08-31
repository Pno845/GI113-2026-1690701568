using System.Collections;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine($"Boss Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}/{MaxLevel}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");
            Console.WriteLine();

            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");
            Console.WriteLine();

            Console.WriteLine("----- Explicit Cast: Attack Power->Display Int -----");
            int attackPowerInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int): {attackPowerInt}");
            Console.WriteLine();

            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critMultiplierIntCast = (int)critMultiplier;
            int critMultiplierIntConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int cast): {critMultiplierIntCast}");
            Console.WriteLine($"Critical Multiplier (Convert rounded): {critMultiplierIntConvert}");
            Console.WriteLine();

            // currentHpDouble ต้องมาจาก currentHp แบบ "implicit" ล้วนๆ — เขียนแค่
            // double currentHpDouble = currentHp;  ไม่ต้องมี (double) นำหน้าเลย
            //
            // ถ้าคำนวณ hpPercentExact จาก currentHp (int) ตรงๆ โดยไม่ผ่าน currentHpDouble ก่อน
            // จะเจอกับดัก int/int=int แบบ Week 2 อีกรอบ (ได้ 47 จำนวนเต็ม ไม่ใช่ 47.916666666666664)
            //
            // (int)critMultiplier ตัดเศษทิ้งเสมอ ได้ 1 ไม่ใช่ 2 — คนละอย่างกับ Convert.ToInt32
            // ที่ปัดเศษ (1.75 ปัดขึ้นเป็น 2) ทั้งสองค่านี้ต้องไม่เท่ากันถ้าทำถูก
            //
            // bossName และ rank ต้องประกาศด้วย var เป๊ะๆ (ไม่ใช่ string/char ตรงๆ) —
            // สคริปต์ตรวจงานจะอ่าน source code เช็คด้วย ไม่ใช่แค่เช็ค output


        }
    }
}
