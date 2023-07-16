namespace CatsAndHosts.Interfaces;

public interface IOwner
{
    public string Name { get; }
    public IReadOnlyCollection<IAnimal> OwnedAnimals { get; }
    public DateOnly DateOfBirth { get; }
}