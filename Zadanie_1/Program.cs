int licznik = 0;
int liczba = 1;
while (licznik < 10)
{
    Console.Write(liczba + " ");
    liczba++;
    licznik++;
}
Console.Write("\n");
liczba = 10;
licznik = 0;
do 
{
    Console.Write(liczba + " ");
    liczba--;
    licznik++;
}
while (licznik < 10);
Console.Write("\n");

liczba = 0;
licznik = 0;
for (int i = 0; i <= 20; i+=2)
{
    Console.Write(liczba + " ");
    liczba += 2;
}