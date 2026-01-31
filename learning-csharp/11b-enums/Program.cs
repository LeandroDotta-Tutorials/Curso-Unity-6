
string name = "Astolfo";
Month currentMonth = (Month) DateTime.Now.Month;

Season currentSeason;

if (currentMonth == Month.January || currentMonth == Month.February || currentMonth == Month.March)
{
    currentSeason = Season.Summer;
}
else if (currentMonth >= Month.April && currentMonth < Month.July)
{
    currentSeason = Season.Autumn;
}
else if (currentMonth >= Month.July && currentMonth < Month.October)
{
    currentSeason = Season.Winter;
}
else
{
    currentSeason = Season.Spring;
}

if (currentSeason == Season.Summer)
{
    Console.WriteLine($"{name}: Com esse clima, tudo que eu queria era estar na piscina bebendo água de coco.");
}
else if (currentSeason == Season.Autumn)
{
    Console.WriteLine($"{name}: Outono é minha estação favorita! O clima é mais ameno, muito bom para pedalar e curtir a natureza");
}
else if (currentSeason == Season.Winter)
{
    Console.WriteLine($"{name}: Nesse frio! Minha bicicleta nem sai da garagem 😅");
}
else if (currentSeason == Season.Spring)
{
    Console.WriteLine($"{name}: Minha alergia anda atacada nos últimos dias (Sniff)");
}