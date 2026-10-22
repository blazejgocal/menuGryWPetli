bool czyKoniecWalki = false;
Random rnd = new Random();
int zdrowieBohatera = rnd.Next(1, 101);
int zdrowiePrzeciwnika = rnd.Next(1, 101);
int silaBohatera = rnd.Next(1, 16);
int silaPrzeciwnika = rnd.Next(1, 16);
int liczbaMiksturG = rnd.Next(1, 6);
int liczbaMiksturP = rnd.Next(1, 6);
int premiaGraczaDoKrytycznego = rnd.Next(1, 3);
int premiaPrzeciwnikaDoKrytycznego = rnd.Next(1, 3);
int tura = 1;
while (!czyKoniecWalki)
{
    bool czyUnikG = false;
    bool czyUnikP = false;
    bool czyAtakG = false;
    bool czyAtakP = false;
    int obrazeniaG = 0;
    int obrazeniaP = 0;
    Console.WriteLine("TURA: " + tura);
    tura++;
    Console.WriteLine("ZdrowieBohatera: " + zdrowieBohatera);
    Console.WriteLine("ZdrowiePrzeciwnika: " + zdrowiePrzeciwnika);
    Console.WriteLine("Wybierz czynność: atak/mikstura/unik");
    string czynnoscGracza = Console.ReadLine()!;
    switch (czynnoscGracza)
    {
        case "atak":
            int szansaNaKrytyczne = rnd.Next(1, 4);
            if (szansaNaKrytyczne == 3)
            {
                obrazeniaG = silaBohatera * premiaGraczaDoKrytycznego;
            }
            else
            {
                obrazeniaG = silaBohatera;
            }
            Console.WriteLine("Wybrano atak.");
            czyAtakG = true;
            break;
        case "mikstura":
            if (liczbaMiksturG != 0)
            {
                zdrowieBohatera += 20;
                liczbaMiksturG--;
                Console.WriteLine("Wykorzystano miksturę. Zdrowie Bohatera: " + zdrowieBohatera);
            }
            else
            {
                Console.WriteLine("Brak mikstur.");
            }
            break;
        case "unik":
            int szansaNaUnik = rnd.Next(1, 3);
            if (szansaNaUnik == 2)
            {
                Console.WriteLine("Wykonano unik");
                czyUnikG = true;
            }
            else
            {
                Console.WriteLine("Nie wykonano uniku.");
            }
            break;
    }

    string czynnoscPrzeciwnika = " ";
    Console.Write("Czynność przeciwnika: ");
    int czynnoscPrzeciwnika1 = rnd.Next(1, 4);
    if (czynnoscPrzeciwnika1 == 3)
    {
        Console.WriteLine("atak.");
        czynnoscPrzeciwnika = "atak";
    }
    else if (czynnoscPrzeciwnika1 == 2)
    {
        Console.WriteLine("mikstura.");
        czynnoscPrzeciwnika = "mikstura";
    }
    else if (czynnoscPrzeciwnika1 == 1)
    {
        Console.WriteLine("unik.");
        czynnoscPrzeciwnika = "unik";
    }

    switch (czynnoscPrzeciwnika)
    {
        case "atak":
            int szansaNaKrytyczne =  rnd.Next(1, 4);
            if (szansaNaKrytyczne == 3)
            {
                obrazeniaP = silaPrzeciwnika * premiaPrzeciwnikaDoKrytycznego;
            }
            else
            {
                obrazeniaP = silaPrzeciwnika;
            }
            czyAtakP = true;
            break;
        case "mikstura":
            if (liczbaMiksturP != 0)
            {
                zdrowiePrzeciwnika += 20;
                liczbaMiksturP--;
            }
            else
            {
                Console.WriteLine("Brak mikstur.");
            }
            break;
        case  "unik":
            int szansaNaUnik = rnd.Next(1, 3);
            if (szansaNaUnik == 2)
            {
                Console.WriteLine("Wykonano unik");
                czyUnikP = true;
            }
            else
            {
                Console.WriteLine("Nie wykonano uniku.");
            }
            break;
    }
}
//dodać porównanie czynności