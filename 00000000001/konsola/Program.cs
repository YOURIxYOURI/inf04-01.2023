using System;

/**********************************************
nazwa funkcji: < Find_NWD >
opis funkcji: < funckja korzysta z algorytmu Euklidesa do wyszukiwania NWD>
parametry: < a – Jedna z liczb potrzebnyc do algorymu
    b – Jedna z liczb potrzebnyc do algorymu>
zwracany typ i opis: < int - liczba odpadowiadająca NWD>
autor: < 00000000001 >
***********************************************
*/
int Find_NWD(int a, int b)
{
    while(a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
        {
            b = b - a;
        }
    }
    return a;
}
Console.WriteLine("Podaj liczbe A");
int user_a = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe B");
int user_b = int.Parse(Console.ReadLine());
if (user_a > 0 && user_b > 0)
{
    Console.WriteLine($"NWD podanych liczb {Find_NWD(user_a, user_b)}");
}
else
{
    Console.WriteLine("Liczby powinny być dodatnie");
}

