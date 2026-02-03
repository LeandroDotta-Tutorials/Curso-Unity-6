const float CHARGE_NORTH = 30f;
const float CHARGE_SOUTH = 25f;
const float CHARGE_SOUTHEAST = 10f;
const float CHARGE_OTHERS = 20f;

Console.Write("Digite o estado (ex: SP, MG, AM): ");
string state = Console.ReadLine().ToUpper();

#region Comando swith padrão
switch (state)
{
    case "AM" or "RR" or "AP" or "PA" or "TO" or "RO" or "AC":
        Console.WriteLine($"Frete para {state}: R${CHARGE_NORTH:.00}");
        break;
    case "PR" or "RS" or "SC":
        Console.WriteLine($"Frete para {state}: R${CHARGE_SOUTH:.00}");
        break;
    case "SP" or "RJ" or "ES" or "MG":
        Console.WriteLine($"Frete para {state}: R${CHARGE_SOUTHEAST:.00}");
        break;
    default:
        Console.WriteLine($"Frete para outros estado: R${CHARGE_OTHERS:.00}");
        break;
}
#endregion

#region Switch expression
float charge = state switch
{
    "AM" or "RR" or "AP" or "PA" or "TO" or "RO" or "AC"    => CHARGE_NORTH,
    "PR" or "RS" or "SC"                                    => CHARGE_SOUTH,
    "SP" or "RJ" or "ES" or "MG"                            => CHARGE_SOUTHEAST,
    _                                                       => CHARGE_OTHERS
};

Console.WriteLine($"Frete para {state}: R${charge:.00}");
#endregion