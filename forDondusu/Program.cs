






Console.WriteLine("Başlangıc aralığı:");
int başlangıc = int.Parse(Console.ReadLine());

Console.WriteLine("Bitiş aralığı:");
int bitis = int.Parse(Console.ReadLine());

Console.WriteLine("Artış miktarı:");
int artis = int.Parse(Console.ReadLine());

int sayac = 0;
int toplam = 0;
for (int i = başlangıc; i <= bitis; i += artis + 1)
{
    sayac++;
    toplam += i;
    Console.WriteLine($"{sayac}.sayı: {i}");
}
Console.WriteLine($"Toplam:{toplam}");

//------------------------------------------------------------------------

int[] numbers = { 1, 3, 5, 7, 9, 12, 18, 23, 67, 90,120,139,999,2548,156455 };
int sayac2 = 0;
int toplam2 = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 3 == 0)
    {
        sayac2++;
        toplam2 += numbers[i];
        
        
        Console.WriteLine($" 3 katları: {numbers[i]} \nToplamlamı:{toplam}");
        Console.WriteLine("************************************************");

    }
    else if (numbers[i]%2==1)
    {
        
        Console.WriteLine($" {sayac}.Carpımları: {numbers[i] * numbers[i]}");
    }


}