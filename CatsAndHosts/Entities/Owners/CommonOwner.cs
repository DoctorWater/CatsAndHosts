using CatsAndHosts.Interfaces;

namespace CatsAndHosts.Entities.Owners;

public class CommonOwner : IOwner
{
    private List<IPet> _ownedAnimals;
    public Guid Id { get; }
    public string Name { get; }
    public DateOnly DateOfBirth { get; }

    public IReadOnlyCollection<IPet> OwnedAnimals => _ownedAnimals;

    public IPet AddPet(IPet pet)
    {
        _ownedAnimals.Add(pet);
        return pet;
    }

    public bool Qualification { get; set; }
}