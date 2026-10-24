using System.Drawing;

bool czyChceGracDalej = true;
//początek tury
while (czyChceGracDalej == true)
{
    //zmienne
    bool czyKoniecWalki = false;
    Random rnd = new Random();
    int zdrowieBohatera = rnd.Next(1, 101);
    int zdrowiePrzeciwnika = rnd.Next(1, 101);
    int liczbaMiksturG = rnd.Next(1, 6);
    int liczbaMiksturP = rnd.Next(1, 6);
    int tura = 1;
    while (!czyKoniecWalki)
    {
        Console.Clear();
        //zmienne resetujące się co turę
        bool czyUnikG = false;
        bool czyUnikP = false;
        bool czyAtakG = false;
        bool czyAtakP = false;
        int obrazeniaG = 0;
        int obrazeniaP = 0;
        int silaBohatera = rnd.Next(10, 16);
        int silaPrzeciwnika = rnd.Next(10, 16);
        int premiaGraczaDoKrytycznego = rnd.Next(1, 5);
        int premiaPrzeciwnikaDoKrytycznego = rnd.Next(1, 5);
        //informacje na początku tury
        Console.WriteLine("TURA: " + tura);
        tura++;
        Console.WriteLine("ZdrowieBohatera: " + zdrowieBohatera);
        Console.WriteLine("ZdrowiePrzeciwnika: " + zdrowiePrzeciwnika);
        Console.WriteLine("Siła gracza: " +  silaBohatera);
        Console.WriteLine("Siła przeciwnika: " + silaPrzeciwnika);
        Console.WriteLine("Premia do siły gracza: " + premiaGraczaDoKrytycznego);
        Console.WriteLine("Premia do siły przeciwnika: " + premiaPrzeciwnikaDoKrytycznego);
        Console.WriteLine("Liczba mikstur gracza:  " + liczbaMiksturG);
        Console.WriteLine("Liczba mikstur przeciwnika: " + liczbaMiksturP);
        Console.WriteLine("Wybierz czynność: atak/mikstura/unik");
        string czynnoscGracza = Console.ReadLine()!;
        //wybieranie czynności gracza
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
                if (liczbaMiksturG > 0)
                {
                    if (zdrowieBohatera + 20 >= 100)
                    {
                        zdrowieBohatera = 100;
                    }
                    else
                    {
                        zdrowieBohatera += 20;
                    }
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
                    Console.WriteLine("Unik nieudany.");
                }
                break;
        }
        //losowanie czynności przeciwnika
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
        //podejmowanie czynności przeciwnika
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
                    if (zdrowiePrzeciwnika + 20 >= 100)
                    {
                        zdrowiePrzeciwnika = 100;
                    }
                    else
                    {
                        zdrowiePrzeciwnika += 20;
                    }
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
        //porównywanie czynności
        switch (czyAtakG, czyAtakP)
        {
            case (true, true):
                if (obrazeniaG > obrazeniaP)
                {
                    zdrowiePrzeciwnika -= obrazeniaG - obrazeniaP;
                }
                else if (obrazeniaG < obrazeniaP)
                {
                    zdrowieBohatera -= obrazeniaP - obrazeniaG;
                }
                break;
            case (true, false):
                if (czyUnikP == true)
                {
                    Console.WriteLine("Przeciwnik uniknął ataku.");
                }
                else
                {
                    zdrowiePrzeciwnika -= obrazeniaG;
                }
                break;
            case (false, true):
                if (czyUnikG == true)
                {
                    Console.WriteLine("Bohater uniknął ataku.");
                }
                else
                {
                    zdrowieBohatera -= obrazeniaP;
                }
                break;
        }
        //sprawdzanie żywotności
        if (zdrowieBohatera <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("KONIEC WALKI. BOHATER ZGINĄŁ");
            Console.ResetColor();
            czyKoniecWalki =  true;
        }
        else if (zdrowiePrzeciwnika <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KONIEC WALKI. BOHATER ZWYCIĘŻYŁ");
            Console.ResetColor();
            czyKoniecWalki = true;
        }
        System.Threading.Thread.Sleep(3000);
    }
    bool petla = true;
    while (petla)
    {
        Console.WriteLine("Czy chcesz zagrać jeszcze raz?");
        string czyChceJeszcze = Console.ReadLine()!;
        if (czyChceJeszcze == "nie")
        {
            czyChceGracDalej = false;
            petla = false;
        }
        else if (czyChceJeszcze == "tak")
        {
            czyKoniecWalki = false;
            petla = false;
        }
    }
}