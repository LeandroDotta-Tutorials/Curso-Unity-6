public class Date
{
    private int day;
    public int Day
    {
        get => day;
        set
        {
            if (value > 0 && value <= 31)
            {
                day = value;
            }
        }
    }

    private int month;
    public int Month
    {
        get => month;
        set
        {
            if (value > 0 && value <= 12)
            {
                month = value;
            }
        }
    }
    public int Year { get; set; }

    public string MonthName
    {
        get
        {
            if (Month == 1) return "Janeiro";
            else if (Month == 2) return "Fevereiro";
            else if (Month == 3) return "Março";
            else if (Month == 4) return "Abril";
            else if (Month == 5) return "Maio";
            else if (Month == 6) return "Junho";
            else if (Month == 7) return "Julho";
            else if (Month == 8) return "Agosto";
            else if (Month == 9) return "Setembro";
            else if (Month == 10) return "Outubro";
            else if (Month == 11) return "Novembro";
            else if (Month == 12) return "Dezembro";
            else return "";
        }
    }

    public string FormattedDate => $"{Day}/{Month:00}/{Year}";
    public string FullDate => $"{Day} de {MonthName} de {Year}";
}