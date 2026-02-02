string name = "Astolfo";
Month currentMonth = (Month) DateTime.Now.Month;

Season currentSeason = currentMonth switch
{
    >= Month.January and < Month.April  => Season.Summer,
    >= Month.April and < Month.July     => Season.Autumn,
    >= Month.July and < Month.October   => Season.Winter,
    _                                   => Season.Spring
};

switch (currentSeason)
{
    case Season.Summer:
        Console.WriteLine($"{name}: Com esse clima, tudo que eu queria era estar na piscina bebendo água de coco.");
        break;

    case Season.Autumn:
        Console.WriteLine($"{name}: Outono é minha estação favorita! O clima é mais ameno, muito bom para pedalar e curtir a natureza");
        break;

    case Season.Winter:
        Console.WriteLine($"{name}: Nesse frio! Minha bicicleta nem sai da garagem 😅");
        break;

    case Season.Spring:
        Console.WriteLine($"{name}: Minha alergia anda atacada nos últimos dias (Sniff)");
        break;
}