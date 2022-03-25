using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız!");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız!");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız!");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız!");
                    break;
                default:
                    Console.WriteLine("Veri bulunamadı!");
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kıştasınız!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahardasınız!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yazdasınız!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahardasınız!");
                    break;
                default:
                break;
            }
        }
    }
}
