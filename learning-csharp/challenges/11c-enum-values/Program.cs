foreach (WeekDay item in Enum.GetValues<WeekDay>())
{
    Console.Write($"{item} - ");

    if (item == WeekDay.Saturday || item == WeekDay.Sunday)
    {
        Console.WriteLine("Final de Semana");
    }
    else
    {
        Console.WriteLine("Dia Útil");
    }
}