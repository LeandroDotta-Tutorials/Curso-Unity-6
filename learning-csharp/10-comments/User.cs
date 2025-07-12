/// <summary>
/// Representa um usuário com email, idade e senha.
/// </summary>
public class User
{
    /// <summary>
    /// Email do usuário
    /// </summary>
    /// <returns>Uma string com o email do usuário.</returns>
    public string Email { get; set; }
    public int Age { get; set; } // Idade do usuário

    // A senha do usuário
    private string password;

    /// <summary>
    /// Cria um novo usuário atribuindo seu email, idade e senha.
    /// </summary>
    /// <param name="email">O email inicial do usuário.</param>
    /// <param name="age">A idade inicial do usuário.</param>
    public User(string email, int age)
    {
        Email = email;
        Age = age;
        password = "!@#$1234ABC";
    }

    /// <summary>
    /// Realiza o login do usuário no sistema.
    /// </summary>
    /// <param name="password">A senha informada pelo usuário</param>
    /// <returns>
    ///     <c>true</c> se o usuário entrou com sucesso, ou 
    ///     <c>false</c> caso a senha seja inválida
    /// </returns>
    public bool Login(string password)
    {
        bool isPasswordCorrect = this.password == password;

        /* Verifica a senha informada e mostra uma mensagem indicando
        que o usuário entrou, caso ela esteja correta, ou
        que a senha é inválida.
         */
        if (isPasswordCorrect)
        {
            Console.WriteLine($"Usuário com email '{Email}' entrou!");
        }
        else
        {
            Console.WriteLine($"Senha inválida para usuário '{Email}'");
        }

        return this.password == password;
    }
}