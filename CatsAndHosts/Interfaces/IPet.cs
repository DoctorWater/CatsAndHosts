namespace CatsAndHosts.Interfaces;

public interface IPet
{
    public Guid Id { get; }
    public string Name { get; }
    public DateOnly DateOfBirth { get; }
    public Sex Sex { get; }
    public IOwner? Owner { get; set; }
    bool HasOwner();
}