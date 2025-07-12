User user = new User("leandrodotta@gmail.com", 34);

Console.WriteLine($"Email do usuário: {user.Email}");

bool loggedIn = user.Login("123456");
