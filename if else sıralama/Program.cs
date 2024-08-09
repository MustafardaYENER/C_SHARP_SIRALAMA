namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayıyı Giriniz.");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Sayıyı Giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());


            

            if (sayi1 > sayi2 && sayi1 > sayi3 && sayi2 > sayi3)
            {
                Console.WriteLine("Sıralama "+(sayi1 +">"+ sayi2 +">"+ sayi3) );
            }
            else if (sayi1 > sayi2 && sayi1 > sayi3 && sayi3 > sayi2)
            {
                Console.WriteLine("Sıralama " + (sayi1 + ">" + sayi3 + ">" + sayi2));
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3 && sayi3 > sayi1)
            {
                Console.WriteLine("Sıralama " + (sayi2 + ">" + sayi3 + ">" + sayi1));
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3 && sayi1 > sayi3)
            {
                Console.WriteLine("Sıralama " + (sayi2 + ">" + sayi1 + ">" + sayi3));
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("Sıralama " + (sayi3 + ">" + sayi1 + ">" + sayi2));
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2 && sayi2 > sayi1)
            {
                Console.WriteLine("Sıralama " + (sayi3 + ">" + sayi2 + ">" + sayi1));
            }
           else if (sayi1 == sayi2 && sayi1 >sayi3)
            {
                Console.WriteLine("Sıralama " + (sayi1 + "=" + sayi2 + ">" + sayi3));
            }
            else if (sayi1 == sayi3 && sayi1 > sayi2)
            {
                Console.WriteLine("Sıralama " + (sayi1 + "=" + sayi3 + ">" + sayi2));
            }
            else if (sayi2 == sayi3 && sayi2 > sayi1)
            {
                Console.WriteLine("Sıralama " + (sayi2 + "=" + sayi3 + ">" + sayi1));
            }
            else if (sayi2 == sayi3 && sayi2 < sayi1)
            {
                Console.WriteLine("Sıralama " + (sayi1 + ">" + sayi2 + "=" + sayi3));
            }
            else if (sayi1 == sayi2 && sayi1 < sayi3)
            {
                Console.WriteLine("Sıralama " + (sayi3 + ">" + sayi1 + "=" + sayi2));
            }
            else if (sayi1 == sayi3 && sayi1 < sayi2)
            {
                Console.WriteLine("Sıralama " + (sayi2 + ">" + sayi1 + "=" + sayi3));
            }







        }
    }
}
