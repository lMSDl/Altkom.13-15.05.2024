using ConsoleApp;
using System;

//StringDemo myDemo = new StringDemo();
//myDemo.Run();

{ //zakres życia zmiennych ogranicają klamerki (niezależnie od tego czy oznaczają one początek/koniec metody czy po prostu bloku kodu jak tutaj)
    int a = 11;
    int b = 4;

    int c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
    c = a / b; // część dziesiętna jest ucięta
    Console.WriteLine($"{a} / {b} = {c}");
    c = a % b; //reszta z dzielenia
    Console.WriteLine($"{a} % {b} = {c}");
}

{
    float a = 11f;
    float b = 4.0f;
    float c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

int intA = 5;
int intB = 7;

//aby wynik był poprawny przy dzieleniu dwóch intów należy jako pierwszą operację "przekształcić" int na float
//możemy to zrobić poprzez wykonanie jako pierwszą operację mnożenia przez typ o większej prezycji
float floatC = 1f * intA / intB;
Console.WriteLine(floatC);

//lub poprzez rzutowanie (czyli potraktowanie jednego typu jako inny (podany w nawiasie))
floatC =  (float)intA / intB;
Console.WriteLine(floatC);

//kolejność działań zgodna z zasadami matematyki
floatC = intA + intA * intA;
Console.WriteLine($"{intA} + {intA} * {intA} = {floatC}");
floatC = (intA + intA) * intA;
Console.WriteLine($"({intA} + {intA}) * {intA} = {floatC}");



Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");

Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

Console.WriteLine(5 / 3.3f); //f - float
Console.WriteLine(5 / 3.3d); //d - double
Console.WriteLine(5 / 3.3m); //m - decimal

//Math to klasa zawierające funkcje przydatne w obliczeniach matematycznych
//domyślne zachowanie funkcji zaokrąglającej powoduje zaokrąglanie do wartości parzystej
Console.WriteLine(Math.Round(2.5));
Console.WriteLine(Math.Round(3.5));

Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));


floatC = 13.1111f;


//formatowanie liczb
// po : wstawiamy format liczby. Może być on szablonem, gdzie 0-9 oznacza zastąpienie brakującej wartości, a # wstawienie wartości gdy jest ona różna od 0
Console.WriteLine($"{floatC:00#.0##}");
//możemy też zastosować predefiniowane formaty: f2 oznacza zachowanie 2 miejsce po przecinku
Console.WriteLine($"{1f / 3f:f2}");

