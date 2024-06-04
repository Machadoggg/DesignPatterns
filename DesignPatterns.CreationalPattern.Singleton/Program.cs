

using DesignPatterns.CreationalPattern.Singleton;

Singleton singleton = Singleton.Instance;
singleton.DoSomething();

Singleton anotherSingleton = Singleton.Instance;
anotherSingleton.DoSomething();


Console.WriteLine(object.ReferenceEquals(singleton, anotherSingleton));
