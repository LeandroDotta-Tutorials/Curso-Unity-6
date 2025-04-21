public class Email
{
    private string? username;
    public string? Username
    {
        get => username;
        set
        {
            if (value?.Length >= 3)
            {
                username = value.ToLower();
            }
            else
            {
                Console.WriteLine($"Username '{value}' inválido!");
            }
        }
    }

    private string? domain;
    public string? Domain
    {
        get => domain;
        set
        {
            if (value != null && value.Contains('.') &&
                (
                    value.EndsWith(".com") ||
                    value.EndsWith(".com.br") ||
                    value.EndsWith(".br")))
            {
                var start = value.Split('.')[0];

                if (start.Length >= 3)
                {
                    domain = value;
                }
                else
                {
                    Console.WriteLine($"Domínio '{value}' inválido!");
                }
            }
            else
            {
                Console.WriteLine($"Domínio '{value}' inválido!");
            }
        }
    }

    public string Address
    {
        get
        {
            if ((Username == null || Username == "") && (Domain == null || Domain == ""))
            {
                return "_invalid_email_";
            }
            else
            {
                return $"{Username}@{Domain}";
            }
        }
    }
}