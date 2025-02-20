// See https://aka.ms/new-console-template for more information
Console.Write("Bir sayı girin: ");
double sayi;


if (double.TryParse(Console.ReadLine(), out sayi))
{
    if (sayi > 0)
    {
        Console.WriteLine("Girilen sayı pozitiftir.");
    }
    else if (sayi < 0)
    {
        Console.WriteLine("Girilen sayı negatiftir.");
    }
    else
    {
        Console.WriteLine("Girilen sayı sıfırdır.");
    }
}
else
{
    Console.WriteLine("Lütfen geçerli bir sayı girin!");
}
