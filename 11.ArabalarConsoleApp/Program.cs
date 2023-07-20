using System.Globalization;

namespace _11.ArabalarConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new();
            cars.Add(new Car() { Marka = "BMW", Model = 2023, MotorGucu = 5000 });
            cars.Add(new Car() { Marka = "Reno", Model = 2020, MotorGucu = 6000 });

            Console.WriteLine("Araba yapay zekasına hoşgeldiniz!");
            Console.WriteLine("Size nasıl yardımcı olabilirim?");
            Console.WriteLine("İşlem Listesi:");
            Console.WriteLine("1 - Araç Listesi");
            Console.WriteLine("2 - Araç Sayısı");
            Console.WriteLine("3 - Araç Ekle");
            Console.WriteLine("4 - Listeyi Göster");
            Console.WriteLine("5 - Çıkış");

            while (true)
            {
                string cevap = Console.ReadLine();


                if (cevap.ToLower() == "Araç Listesi".ToLower())
                {
                    foreach (Car car in cars)
                    {
                        Console.WriteLine($"Marka : {car.Marka} - Model: { car.Model} - Motor Gücü {car.MotorGucu}");
                    }
                }

                else if (cevap.ToLower() == "Araç Sayısı".ToLower())
                {
                    Console.WriteLine($"Toplam araç sayısı: {cars.Count()}");
                }

                else if (cevap.ToLower() == "Araç Ekle".ToLower())
                {
                    Console.WriteLine("Aracın markasını yazın:");
                    string marka  = Console.ReadLine();

                tekrar1:;

                    Console.WriteLine("Aracın modelini yazın:");
                    string modelString = Console.ReadLine();
                    int model = 0;
                    if (!int.TryParse(modelString, out model))
                    {
                        Console.WriteLine("Model bir sayı olmalıdır.");
                        goto tekrar1;
                    }

                tekrar2:;

                    Console.WriteLine("Aracın motor gücünü yazın:");
                    string motorGucuString = Console.ReadLine();
                    int motorGucu = 0;
                    if (!int.TryParse(motorGucuString, out motorGucu))
                    {
                        Console.WriteLine("Motor Gücü bir sayı olmalıdır");
                        goto tekrar2;
                    }

                    Car car = new();
                    car.Marka = marka;
                    car.Model = model;
                    car.MotorGucu = motorGucu;

                    cars.Add(car);
                    Console.WriteLine("Arabanız başarıyla eklenmiştir.");
                }


                else if (cevap.ToLower() == "Çıkış".ToLower())
                {
                    Console.WriteLine("Ziyaret ettiğiniz için teşekkürler. Tekrar görüşmek üzere.");
                    break;
                }

                else if (cevap.ToLower() == "Listeyi Göster".ToLower()) 
                {
                    Console.WriteLine("İşlem Listesi:");
                    Console.WriteLine("1 - Araç Listesi");
                    Console.WriteLine("2 - Araç Sayısı");
                    Console.WriteLine("3 - Araç Ekle");
                    Console.WriteLine("4 - Listeyi Göster");
                    Console.WriteLine("5 - Araç Kirala");
                    Console.WriteLine("6 - Çıkış");
                }

                else if (cevap.ToLower() == "Araç Kirala".ToLower())
                {
                    
                    for (int x = 0; x < cars.Count(); x++)
                    {
                        Console.WriteLine($"{x+1} {cars[x].Marka}");
                    }

                tekrar3:;

                    Console.WriteLine("Araç seçimi yapın?");
                    Console.WriteLine("Araç Numarası");
                    string secilenAracString = Console.ReadLine();
                    int secilenArac = 0;
                    if (!int.TryParse(secilenAracString, out secilenArac))
                    {
                        Console.WriteLine("Sadece sayı ile araç seçebilirsiniz");
                        goto tekrar3;
                    }

                    if (secilenArac > cars.Count())
                    {
                        Console.WriteLine("Seçtiğiniz araç filoda bulunmuyor.");
                        goto tekrar3;
                    }

                    Console.WriteLine("Kiralama Tarihi :");
                    string kiralamaTarihi = Console.ReadLine();

                    Console.WriteLine("Kiralama Saati :");
                    string kiralamaSaati = Console.ReadLine();

                    Console.WriteLine("Teslim Tarihi :");
                    string teslimTarihi = Console.ReadLine();

                    Console.WriteLine("Teslim Saati :");
                    string teslimSaati = Console.ReadLine();

                    Console.WriteLine($"{cars[secilenArac - 1].Marka} marka aracını {kiralamaSaati} {kiralamaTarihi} tarihinde kiralamak üzere işlem yaptınız. Teslim tarihiniz {teslimTarihi} {teslimSaati}");
                    Console.WriteLine("Aracı zamanında teslim etmezseniz cezai işlem uygulanacaktır.");
                }

                else
                {
                    Console.WriteLine("Ben henüz olgunlaşmamış bir yapay zekayım. Sadece listedeki işlemleri yapabilirim");
                }

                Console.WriteLine("Başka ne işlem yapmak istersiniz?");
            }
        }
    }
}

public class Car
{
    public string Marka;
    public int Model;
    public int MotorGucu;
}