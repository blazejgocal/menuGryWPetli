Console.WriteLine("Podaj wysokość choinki");
int wysokosc = int.Parse(Console.ReadLine());
int licznikSpacji = 1;
int licznikGwiazd = 1;
for (int i = 0; i < wysokosc; i++)
{
    for (int j = 0; j < wysokosc - licznikSpacji; j++)
    {
        Console.Write(" ");
    }
    for(int x = 0; x < licznikGwiazd ; x++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
    licznikSpacji++;
    licznikGwiazd+=2;
}

for (int i = 0; i < wysokosc -1; i++)
{
    Console.Write(" ");
}
Console.WriteLine("*");