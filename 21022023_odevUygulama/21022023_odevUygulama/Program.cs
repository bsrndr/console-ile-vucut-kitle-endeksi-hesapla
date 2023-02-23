#region SORU-1
//Kullanıcının girdiği boy ve ağırlık değerlerine göre vücut kitle indeksini hesaplayıp durumunu ekrana yazdıran program. Bilgiler doğru girilmek zorundadır.//(VKİ = ağırlık / (boy * boy), boy metre cinsinden verilmeli)//(VKİ 18 ile < 25 aralığındaysa normal, VKİ 25 ile < 30 aralığındaysa kilolu, VKİ 30 ve daha yüksekse obez, VKİ 35 ve daha fazlaysa ciddi obez olarak kabul edilir.)

double boyBilgisi = 0, agirlikBilgisi = 0, vucutKitleEndeksi = 0;
bool cevap1 = false;
bool cevap2 = false;

do
{
    Console.WriteLine("Lütfen boy bilgisi giriniz:");
    cevap1 = Double.TryParse(Console.ReadLine(), out boyBilgisi);
    Console.WriteLine("Lütfen ağırlık bilgisini giriniz:");
    cevap2 = Double.TryParse(Console.ReadLine(), out agirlikBilgisi);
}
while (cevap1 == false || cevap2 == false || boyBilgisi <= 0 || boyBilgisi > 3 || agirlikBilgisi <= 0 || agirlikBilgisi > 300);

vucutKitleEndeksi = agirlikBilgisi / (boyBilgisi * boyBilgisi);

if (vucutKitleEndeksi >= 18 && vucutKitleEndeksi <= 25)
{
    Console.WriteLine("Vücut kitle endeksi: Normal");
}
else if (vucutKitleEndeksi > 25 && vucutKitleEndeksi <= 30)
{
    Console.WriteLine("Vücut kitle endeksi: Kilolu");
}
else if (vucutKitleEndeksi > 30 && vucutKitleEndeksi <= 35)
{
    Console.WriteLine("Vücut kitle endeksi: Obez");
}
else if (vucutKitleEndeksi >= 36)
{
    Console.WriteLine("Vücut kitle endeksi: Ciddi Obez");
}
//#endregion

#region SORU-2
///Kullanıcıdan mavi yeşil kırmızı sarı renklerinden birini seçmesini isteyin. Kullanıcı hangi rengi secerse konsolun arka plan rengini o renge çeviriniz.

string renk =" ";
Console.WriteLine("Lütfen mavi, yeşil, kırmızı ve sarı bir renk seçiniz");
renk = Console.ReadLine();

if (renk == "mavi")
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Yellow;
}
else if (renk == "yesil")
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Red;
}
else if (renk == "kirmizi")
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Green;
}
else if (renk == "sari")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Magenta;
}
else
{
    Console.WriteLine("Lütfen geçerli bir renk seçiniz");
}
#endregion

#region soru-1 2.yöntem
//int weight;
//double height;

//while (true)
//{
//    Console.WriteLine("Ağırlık giriniz");
//    bool weightIsInt =int. TryParse(Console.ReadLine(),out weight);
//    Console.WriteLine("Boy giriniz");
//    bool heightIsInt = int.TryParse(Console.ReadLine(), out height);
//    if (weightIsInt && heightIsInt && height >0 && weight >0)
//    {
//        double vki = weight / (height * height);
//        if (vki <= 18) Console.WriteLine("zayıf");
//        {
//            else if (vki >18 && vki<=25)

//                Console.WriteLine("normal");

//            else if (vki > 25 && vki <= 30)

//                Console.WriteLine("kilolu");

//            else if (vki > 30 && vki <= 35)

//                Console.WriteLine("obez");

//            else if (vki > 35)

//                Console.WriteLine("ciddi obez");

//            break;
//        }

//    }
//    else
//    {
//        Console.WriteLine("Hatalı giriş yaptınız");
//    }
//} 
#endregion