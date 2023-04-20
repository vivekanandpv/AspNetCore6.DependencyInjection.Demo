namespace AspNetCore6.DependencyInjection.Demo.Models;

public class Person
{
    private readonly Car _car;
    
    public Person(Car car)
    {
        Console.WriteLine("Person created");
        _car = car;
    }
}