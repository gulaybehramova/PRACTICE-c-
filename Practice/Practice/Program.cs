using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Daxil edilmis string deyerinin icinde reqem olub olmadigini tapan proqram;
            #region Task1
            //Console.WriteLine("TEXT DAXIL EDIN:");
            //string text = Console.ReadLine();
            //bool hasChar = false;
            //char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int a = 0; a < digits.Length; a++)
            //    {
            //        if (text[i] == digits[a])
            //        {
            //            hasChar = true;
            //            break;
            //        }
            //    }
            //}
            //if (hasChar)
            //    Console.WriteLine(text + " yazisinda reqem var!");
            //else
            //    Console.WriteLine(text + " yazisinda reqem yoxdur!");
            #endregion



            //2.Daxil edilmis string deyerinde ardicil a ve l charlarinin olub olmadigini tapan proqram.Misalcun alma, salam ve s. kimi sozlerde "vardir" yazdirmalidir geriye.
            #region Task2
            //Console.WriteLine("text daxil edin:");
            //string text = Console.ReadLine();
            //bool hasChar = false;
            //for (int i = 0; i < text.Length; i++)
            //{
            //            if (text[i] == 'a' && text[i + 1] == 'l')
            //            {
            //                hasChar = true;
            //                break;
            //            }
            //}
            //if (hasChar)
            //    Console.WriteLine("vardir");
            //else
            //    Console.WriteLine("yoxdur");
            #endregion



            //3.Verilmis ededin reqemlerinin ededi ortasini tapan proqram
            #region Task3
            //int digit = 348;
            //int lastdigit;
            //int sum = 0;
            //int count = 0;
            //int result;
            //while (digit > 0)
            //{
            //    lastdigit = digit % 10;
            //    sum += lastdigit;
            //    digit = (digit - lastdigit) / 10;
            //    count++;
            //}
            //result = sum / count;
            //Console.WriteLine(result);
            #endregion
        }
    }
}
