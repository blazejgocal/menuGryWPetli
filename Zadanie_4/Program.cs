bool czyPodal = false;
while (!czyPodal)
{
    Console.WriteLine("Podaj liczbę tur od 1 do 10");
    string tury1 = Console.ReadLine()!;
    if (int.TryParse(tury1, out int tury))
    {
        
        if (tury >= 1 && tury <= 10)
        {
            Console.WriteLine("Rozpoczynam grę na " + tury + " tur.");
            czyPodal = true;
        }
        else if (tury > 10 || tury < 1)
        {
            Console.WriteLine("Liczba musi należeć do zakresu 1-10.");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }
}
