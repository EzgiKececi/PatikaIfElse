Console.Write("Lütfen bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi == 10) // Birinci karar yapısı ile girilen sayının 10'a eşitliği ile büyük ya da küçük olma durumuna bakılacaktır
{
    Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
}
else if  (sayi <= 10)
{
    Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
}

if (sayi %2 == 0) // ikinci karar yapısı ile girilen sayının tek mi çift mi olduğuna bakılacaktır
{
    Console.WriteLine("Girdiğinz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}