using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascalUcgeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasgal ucgeni olusturma uygulamasina hosgeldiniz...");
            while(true)
            {
                Console.WriteLine("\n----------ANA MENU----------");
                Console.WriteLine("Pascal ucgeni olusturmak icin --> 1");
                Console.WriteLine("Cikis icin --> 0");
                Console.Write("Lutfen yapmak istediginiz islemi seciniz:");
                string secim = Console.ReadLine();

                switch(secim)
                {
                    case "0":
                        Console.WriteLine("Bizi tercih ettiginiz icin tesekkur ederiz. Cikis yapiliyor...");
                        Environment.Exit(0);
                        break;
                    case "1":
                        Console.Write("Lutfen ucgenin kac satir icerecegini giriniz:");
                        string stringSatir = Console.ReadLine();
                        if(int.TryParse(stringSatir,out int satir))
                        {
                           int[,] dizi = new int[satir,satir];
                           int i = 0, j = 0;
                           for(i=0;i<satir;i++)
                            {
                                for(j=0;j<=i;j++)
                                {
                                    if(j==0 || j==i)
                                    {
                                        dizi[i,j] = 1;
                                    }
                                    else
                                    {
                                        dizi[i,j] = dizi[i - 1,j - 1] + dizi[i - 1,j];
                                    }
                                }
                            }

                           for(i=0;i<satir; i++)
                            {
                                for(int k=0;k<satir-i-1;k++)
                                {
                                    Console.Write(" ");
                                }
                                for(j=0;j<=i;j++)
                                {
                                    Console.Write(dizi[i,j]+" ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lutfen gecerli deger giriniz!!!");
                            continue;
                        }
                            break;
                    default:
                        Console.WriteLine("Lutfen gecerli deger giriniz!!!");
                        break;
                }
            }
        }
    }
}
