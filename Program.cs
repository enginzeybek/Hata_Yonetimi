// See https://aka.ms/new-console-template for more information


try
{
    Console.WriteLine("Bir sayı giriniz");
    int sayi = int.Parse(Console.ReadLine());
    Console.WriteLine("Girilen Sayi: " + sayi);
}
catch(Exception ex) 
{
    Console.WriteLine("Hata: " + ex.Message.ToString());
}
finally
{
    Console.WriteLine("İşlem tamamlandı"); // hata alsın almasın kullanılan bulok finally.
}


