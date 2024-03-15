using ClassLibrary2;
using System;

//Разработать модуль для описания системы Аэрофлот.
//Описать следующие классы: Рейсы(номер рейса, пункт назначения, вид самолета время в пути),
//внутренний рейс (количество пассажиров)
//международный рейс (страна назначения, промежуточные посадки).
//Создать консольное приложение для ввода данных.

int otv;
List <Airport> list_of_airport = new List<Airport>();
do
{
    Console.WriteLine("Выберете 1 - Рейсы, 3 - Международынй рейс");
    otv = Convert.ToInt32(Console.ReadLine());
    if (otv == 1)
    {
        Domestic_Flight vnutReys = new Domestic_Flight();
        Console.WriteLine("Введите номер рейса");
        vnutReys.Numerreys = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Пункт назначения");
        vnutReys.Punktn = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Вид самолета");
        vnutReys.Type = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Время в пути");
        vnutReys.Time = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите количесвто пассажиров");
        vnutReys.Number_of_flights = Convert.ToInt32(Console.ReadLine());
        list_of_airport.Add(vnutReys);
    }
    else if (otv == 3)
    {
        International_Flight vnutReys = new International_Flight();
        Console.WriteLine("Введите страну назначения");
        vnutReys.Destination_Country = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Промежуточные посадки");
        vnutReys.Intermediate_landings = Convert.ToString(Console.ReadLine());
    }
    Console.WriteLine("Продожить - '4'");
    otv = Convert.ToInt32(Console.ReadLine());
}
while (otv == 4);

foreach (Domestic_Flight vnutReys in list_of_airport)
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine($"Количество пассажиров: {vnutReys.Number_of_flights} |-| Номер рейса:{vnutReys.Numerreys} |-| {vnutReys.Punktn}|");
    Console.WriteLine("-------------------------------------------");
}




