using System;

namespace Chapter4
{
    class Dicecount
    {
        static void Main(string[] args)
        {
            int num, num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
            System.Random rnd = new System.Random();
            for(int i=1;i<=100;i++)
            {
                num = (int)rnd.Next(1, 7);
                switch(num)
                {
                    case 1:
                        num1++;
                        break;
                    case 2:
                        num2++;
                        break;
                    case 3:
                        num3++;
                        break;
                    case 4:
                        num4++;
                        break;
                    case 5:
                        num5++;
                        break;
                    case 6:
                        num6++;
                        break;
                    default:
                        Console.WriteLine("other than 1 to 6");
                        break;
                }
            }
            Console.WriteLine("1 : {0} \n 2 : {1} \n 3 : {2} \n 4 : {3} \n 5 : {4} \n 6 : {5} ", num1, num2, num3, num4, num5, num6);
        }
    }
}
