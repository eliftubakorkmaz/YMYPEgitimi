using System.Reflection.Metadata.Ecma335;

namespace _06.Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> names = new();
            names.Add("Elif");
            names.Add("Şeref");
            names.Add("Füsun");
            names.Add("Cumhan");
            names.Add("Halil");
            names.Add("Tuba");

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[5]);

            //for, foreach, while

            //for(int x = 0; x < names.Count(); x++) 
            //{
                  //if (x == 4)
                  //{
                  //      break; // döngüyü sonlandırır
                  //}
                  //if (x == 2)
                  //{
                  //      continue; // bu da döngüde kalan kısmı atlar
                  //}
            //    Console.WriteLine(names[x]);
            //}

            //foreach (var x in names)
            //{
            //    Console.WriteLine(x);
            //}

            //int x = 0;
            //while (names.Count > 0) 
            //{
            //    x++;
            //    if (x == 5) break;
            //    Console.WriteLine("Çalışılıyor.");
            //}

            //do
            //{
            //    Console.WriteLine("Çalışıyor");
            //} while (names.Count < 0 );

            //oop içerisinde tip belirtmek zorunda olduğun için liste belirtilen tipte olmak zorunda
            //json formatı kullanıyor olsaydın listede farkli tipler olabilirdi
        }
    }
}