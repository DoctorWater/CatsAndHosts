namespace CatsAndHosts.Interfaces;

public interface IRequest
{
    public Guid Id { get; }
    public RequestStatus Status { get; set; }
    public IOwner Owner { get; }
    public IPet Pet { get; }
}