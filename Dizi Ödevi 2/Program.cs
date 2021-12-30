using System;

namespace Dizi_Ödevi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,,] dizi = new double[2, 4, 3];
            int[,] katsayi = new int[4, 3] { { 1, 5, 3 }, { 5, 1, 3 }, { 0, 6, 3 }, { 6, 0, 3 } };
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    Console.WriteLine("Ali'nin ");
                else if (i == 1)
                    Console.WriteLine("Ayşe'nin ");

                Console.WriteLine("---------------------------");
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                        Console.Write("Türkçe Dersinin ");
                    else if (j == 1)
                        Console.Write("Matematik Dersinin ");
                    else if (j == 2)
                        Console.Write("Sosyal Dersinin ");
                    else if (j == 3)
                        Console.Write("Fen Dersinin ");
                    for (int k = 0; k < 3; k++)
                    {
                        if(k==2)
                        {
                            dizi[i, j, k] = dizi[i, j, 0] - dizi[i, j, 1] / 4;
                        }
                        else if(k==0)
                        {
                            Console.Write("Doğru Sayısını Girin: ");
                            dizi[i, j, k] = Convert.ToDouble(Console.ReadLine());
                        }
                        else if(k==1)
                        {
                            Console.Write("Yanlış Sayısını Girin: ");
                            dizi[i, j, k] = Convert.ToDouble(Console.ReadLine());
                        }
                    }                    
                }
                Console.WriteLine("-------------------");
            }

            for (int i2 = 0; i2 < 2; i2++)
            {
                if (i2 == 0)
                    Console.WriteLine("Ali'nin");
                else if (i2 == 1)
                    Console.WriteLine("Ayşe'nin");

                Console.WriteLine("-----------------------");
                for (int j2 = 0; j2 < 4; j2++)
                {
                    if (j2 == 0)
                        Console.WriteLine("Türkçe Net Sayısı: " + dizi[i2, j2, 2]);
                    else if (j2 == 1)
                        Console.WriteLine("Matematik Net Sayısı: " + dizi[i2, j2, 2]);
                    else if (j2 == 2)
                        Console.WriteLine("Sosyal Net Sayısı: " + dizi[i2, j2, 2]);
                    else if (j2 == 3)
                        Console.WriteLine("Fen Net Sayısı: " + dizi[i2, j2, 2]);
                }
                Console.WriteLine("----------------------");
            }

            for (int i3 = 0; i3 < 2; i3++)
            {
                if (i3 == 0)
                    Console.WriteLine("Ali'nin");
                else if (i3 == 1)
                    Console.WriteLine("Ayşe'nin");

                Console.WriteLine("--------------------");
                    for (int n = 0; n < 3; n++)
                    {
                        if (n == 0)
                            Console.WriteLine("Sayısal Puanı= " + (dizi[i3,0,2]*katsayi[0,0] + dizi[i3, 1, 2] * katsayi[1, 0] + dizi[i3, 2, 2] * katsayi[2, 0] + dizi[i3, 3, 2] * katsayi[3, 0]));
                        else if (n == 1)
                            Console.WriteLine("Sözel Puani= " + (dizi[i3, 0, 2] * katsayi[0, 1] + dizi[i3, 1, 2] * katsayi[1, 1] + dizi[i3, 2, 2] * katsayi[2, 1] + dizi[i3, 3, 2] * katsayi[3, 1]));
                        else if (n == 2)
                            Console.WriteLine("Eşit Ağırlık Puanı= " + (dizi[i3, 0, 2] * katsayi[0, 2] + dizi[i3, 1, 2] * katsayi[1, 2] + dizi[i3, 2, 2] * katsayi[2, 2] + dizi[i3, 3, 2] * katsayi[3, 2]));
                    }
                Console.WriteLine("--------------------");
            }            
            Console.ReadKey();
        }
    }
}
