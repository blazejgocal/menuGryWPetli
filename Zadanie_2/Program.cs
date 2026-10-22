Console.WriteLine("Ile dni trwa wyprawa?");
int liczbaDni = int.Parse(Console.ReadLine());
int licznikZlota = 0;
int licznikDniWiecejNizDziesiec = 0;
Random rnd = new Random();
for (int i = 0; i < liczbaDni; i++)
{
    int zloto = rnd.Next(1, 100);
    Console.WriteLine("Złoto znalezione w dniu " + i + ": " + zloto);
    licznikZlota += zloto;
    if (zloto >= 50)
    {
        licznikDniWiecejNizDziesiec++;
    }
}
Console.WriteLine("Łącznie znaleziono: " +  licznikZlota + " sztuk złota");
Console.WriteLine("Dni z wynikiem powyżej 10: " + licznikDniWiecejNizDziesiec + ".");