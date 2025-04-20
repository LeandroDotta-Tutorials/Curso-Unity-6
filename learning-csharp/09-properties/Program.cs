Profile profile = new Profile();

profile.Name = "Fulano da Silva";
profile.Status = "Jogando Stardew Valley...";

profile.AddExperience(1000);
profile.AddExperience(1000);
profile.AddExperience(1000);

Console.WriteLine($"""
======================================
{profile.DisplayHeader}
--------------------------------------
- Exp: {profile.Experience}
======================================
""");