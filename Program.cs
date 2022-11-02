// Zad 1 - Medium - Oblicz sumę n pierwszych liczb trzycyfrowych
/*
int n = int.Parse(Console.ReadLine()), suma = 0;
for (int i = 100; i < 100 + n; i++) suma += i;
Console.WriteLine(suma);
*/

//Zad 2 - L Hard - Napisz sumę k początkowych liczb fibbonaciego
/*
int k = int.Parse(Console.ReadLine()), suma = 1;
for (int i = 2; i < k; i++)
{
    suma += i;
    Console.WriteLine(i);
}
Console.WriteLine(suma);
*/

//Zad 3 - L Hard - Sprawdzenie czy liczba n jest doskonała, czyli równa sumie swoich dzielników bez niej samej
/*
int n = int.Parse(Console.ReadLine()), suma = 0;
for (int i = 1; i < n; i++) if (n % i == 0) suma += i;
if (suma == n) Console.WriteLine("TAK");
else Console.WriteLine("NIE");
*/

//Zad 4 - Medium - Znajdź sumę n początkowych wyrazów ciągu:
// a) 3 + 6 + 12 + 24 + 48
// b) 1 + 4 + 7 + 10 + 13
// c) 5 - 10 + 20 - 40 + 60
Console.WriteLine(3+6+12+24+48);
int n = int.Parse(Console.ReadLine()),suma=0,x=0;
for (int i = 0; i <= n; i++)
{
    x = i * 2;
    suma += (int)(Math.Pow(2, i);
}
Console.WriteLine(suma);