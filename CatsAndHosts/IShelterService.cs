using CatsAndHosts.Interfaces;

namespace CatsAndHosts;

public interface IShelterService
{
    public IReadOnlyCollection<IPet> GetAllPets();
    public IPet GetPet(Guid id);
    public IReadOnlyCollection<IOwner> GetAllOwners();
    public IOwner GetOwner(Guid id);
    public IOwner RegisterNewOwner(IOwner owner);
    public IPet RegisterNewPet(IPet pet);
    public IRequest RegisterNewRequest(IRequest request);
    public bool ChangeOwnerToQualified(Guid id);
    public void ChangeRequestStatus(Guid id, RequestStatus newStatus);
    public void SatisfyRequest(Guid id);
}