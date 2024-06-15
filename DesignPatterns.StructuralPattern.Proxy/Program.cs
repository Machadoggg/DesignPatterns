

using DesignPatterns.StructuralPattern.Proxy;

IUserDatabase userDatabase = new UserDatabaseProxy();

Console.WriteLine(userDatabase.GetUserData(1)); // Fetching from real database
Console.WriteLine(userDatabase.GetUserData(2)); // Fetching from real database
Console.WriteLine(userDatabase.GetUserData(1)); // Returning cached data
