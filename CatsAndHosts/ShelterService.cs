using CatsAndHosts.Exceptions;
using CatsAndHosts.Exceptions.NotFound;
using CatsAndHosts.Interfaces;

namespace CatsAndHosts;

public class ShelterService : IShelterService
{
    private List<IPet> _pets = new List<IPet>();
    private List<IOwner> _owners = new List<IOwner>();
    private List<IRequest> _requests = new List<IRequest>();

    public IReadOnlyCollection<IPet> Pets => _pets;

    public IReadOnlyCollection<IOwner> Owners => _owners;

    public IReadOnlyCollection<IRequest> Requests => _requests;

    public IReadOnlyCollection<IPet> GetAllPets()
    {
        return Pets;
    }

    public IPet GetPet(Guid id)
    {
        IPet? result = Pets.FirstOrDefault(pet => pet.Id == id);
        if (result is not null)
        {
            return result;
        }

        throw new PetNotFoundException(id);
    }

    public IReadOnlyCollection<IOwner> GetAllOwners()
    {
        return Owners;
    }

    public IOwner GetOwner(Guid id)
    {
        IOwner? result = Owners.FirstOrDefault(owner => owner.Id == id);
        if (result is not null)
        {
            return result;
        }

        throw new OwnerNotFoundException(id);
    }

    public IOwner RegisterNewOwner(IOwner owner)
    {
        _owners.Add(owner);
        return owner;
    }

    public IPet RegisterNewPet(IPet pet)
    {
        _pets.Add(pet);
        return pet;
    }

    public IRequest RegisterNewRequest(IRequest request)
    {
        _requests.Add(request);
        return request;
    }

    public bool ChangeOwnerToQualified(Guid id)
    {
        IOwner? foundOwner = Owners.FirstOrDefault(owner => owner.Id == id);
        if (foundOwner is not null)
        {
            foundOwner.Qualification = true;
        }

        throw new OwnerNotFoundException(id);
    }

    public void ChangeRequestStatus(Guid id, RequestStatus newStatus)
    {
        IRequest? foundRequest = Requests.FirstOrDefault(request => request.Id == id);
        if (foundRequest is not null)
        {
            foundRequest.Status = newStatus;
        }

        throw new RequestNotFoundException(id);
    }

    public void SatisfyRequest(IRequest request)
    {
        if (request.Status != RequestStatus.Satisfying)
        {
            throw new WrongRequestStatusException(request.Status, RequestStatus.Satisfying);
        }

        AssignPetToOwner(request.Pet, request.Owner);
    }

    private void SatisfyAllSuitableRequests()
    {
        _requests
            .Where(request => request.Status.Equals(RequestStatus.Satisfying))
            .ToList()
            .ForEach(SatisfyRequest);
    }

    private void AssignPetToOwner(IPet pet, IOwner owner)
    {
        pet.Owner = owner;
        owner.AddPet(pet);
    }
    
    
}