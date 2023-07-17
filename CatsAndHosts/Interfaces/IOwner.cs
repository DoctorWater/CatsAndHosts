namespace CatsAndHosts.Interfaces;

public interface IOwner
{
    public Guid Id { get; }
    public string Name { get; }
    public DateOnly DateOfBirth { get; }
    public IReadOnlyCollection<IPet> OwnedAnimals { get; }
    public IPet AddPet(IPet pet);
    public bool Qualification { get; set; }
}