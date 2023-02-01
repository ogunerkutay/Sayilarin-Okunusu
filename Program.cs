using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sayilarin_Okunusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int girilensayi = 0;
            bool isNumeric = false;
            int okunacak = 0;
            string okunan = string.Empty;
            int basamak = 1;
            do
            {
                Console.WriteLine("Lütfen okunmasını istediğiniz 0-999 arası pozitif tam sayıyı giriniz!");
                isNumeric = int.TryParse(Console.ReadLine(), out girilensayi);
            } while (!isNumeric || girilensayi<0 || girilensayi>999);


            while (girilensayi>0)
            {
                okunacak = girilensayi % 10;
                girilensayi /= 10;
                switch (okunacak)
                {
                    case 0:
                        basamak++;
                        break;
                    case 1:
                        if (basamak == 1)
                        {
                            okunan += "bir ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "on " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "Yüz " + okunan;
                        }
                        break;
                    case 2:
                        if (basamak == 1)
                        {
                            okunan += "iki ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "yirmi " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "İkiyüz " + okunan;
                        }
                        break;
                    case 3:
                        if (basamak == 1)
                        {
                            okunan += "üç ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "otuz " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "Üçyüz" + okunan;
                        }
                        break;
                    case 4:
                        if (basamak == 1)
                        {
                            okunan += "dört ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "kırk " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "Dörtyüz " + okunan;
                        }
                        break;
                    case 5:
                        if (basamak == 1)
                        {
                            okunan += "beş ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "elli " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "Beşyüz " + okunan;
                        }
                        break;
                    case 6:
                        if (basamak == 1)
                        {
                            okunan += "altı ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "altmış " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "Altıyüz " + okunan;
                        }
                        break;
                    case 7:
                        if (basamak == 1)
                        {
                            okunan += "yedi ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "yetmiş " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "Yediyüz " + okunan;
                        }
                        break;
                    case 8:
                        if (basamak == 1)
                        {
                            okunan += "sekiz ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "seksen " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "Sekizyüz " + okunan;
                        }
                        break;
                    case 9:
                        if (basamak == 1)
                        {
                            okunan += "dokuz ";
                        }
                        else if (basamak == 2)
                        {
                            okunan = "doksan " + okunan;
                        }
                        else if (basamak == 3)
                        {
                            okunan = "Dokuzyüz " + okunan;
                        }
                        break;
                }
                basamak++;
            }
               
            Console.WriteLine(okunan);
            
        }
    }
}
