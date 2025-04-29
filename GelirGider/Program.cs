namespace GelirGider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gelir;
            double gider;
            double aySonuBakiyesi = 0;

        ayseçim:
            Console.WriteLine("Hangi ay için işlem yapmak istiyorsunuz? Rakam ile yazınız!");
            string ay = Console.ReadLine();
            if (ay == "1")
            {
                ay = "Ocak";
            }
            else if (ay == "2")
            {
                ay = "Şubat";
            }
            else if (ay == "3")
            {
                ay = "Mart";
            }
            else if (ay == "4")
            {
                ay = "Nisan";
            }
            else if (ay == "5")
            {
                ay = "Mayıs";
            }
            else if (ay == "6")
            {
                ay = "Haziran";
            }
            else if (ay == "7")
            {
                ay = "Temmuz";
            }
            else if (ay == "8")
            {
                ay = "Ağustos";
            }
            else if (ay == "9")
            {
                ay = "Eylül";
            }
            else if (ay == "10")
            {
                ay = "Ekim";
            }
            else if (ay == "11")
            {
                ay = "Kasım";
            }
            else if (ay == "12")
            {
                ay = "Aralık";
            }
            else
            {
                Console.WriteLine("Bilinmeyen bir ay girdiniz lütfen 1 den 12 ye kadar bir rakam giriniz!");
                goto ayseçim;
            }


        başlangıç:


            Console.WriteLine("Gelir girmek için 1'e basınız, gider girmek için 2'ye basınız, bakiyeyi görmek için 3'e basınız:");

            string verituru = Console.ReadLine();
            if (verituru == "1")
            {
                Console.WriteLine("tutar giriniz:");
                gelir = Convert.ToDouble(Console.ReadLine());

                aySonuBakiyesi += gelir;
                goto başlangıç;
            }
            else if (verituru == "2")
            {
                Console.WriteLine("tutar giriniz:");
                gider = Convert.ToDouble(Console.ReadLine());
                aySonuBakiyesi -= gider;
                goto başlangıç;

            }
            else if (verituru == "3")
            {
                Console.WriteLine($"{ay} ayında aysonu bakiyeniz: {aySonuBakiyesi}TL ");
                if (aySonuBakiyesi < 0)
                {
                    Console.WriteLine($"{ay} ayında ödemeniz gereken borçlar var");
                }
            }
            else
            {
                Console.WriteLine("Bilinmeyen bir veri girdiniz! Lütfen tekrar deneyin");
                goto başlangıç;
            }
                Console.WriteLine("Ay degiştirmek için 1, yeniden gelir yada gider girebilmek için 2 ye basın.");
            int baslangıclar = Convert.ToInt32( Console.ReadLine());

            if (baslangıclar == 1)
            { 
                Console.Clear();
                goto ayseçim;
            }
            if (baslangıclar == 2)
            {
                Console.Clear();
                goto başlangıç;
            }
        }
    }
}
