namespace CatsAndHosts.Interfaces;

public interface IAnimal
{
    public string Name { get; }
    public DateOnly DateOfBirth { get; }
    public IOwner? Host { get; }
    bool HasHost();
}