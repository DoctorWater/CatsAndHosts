using CatsAndHosts;
using CatsAndHosts.Entities;
using CatsAndHosts.Interfaces;

namespace Shelter.Test;

public class UnitTest1
{
    [Fact]
    public IReadOnlyCollection<IPet> GetAllPets()
    {
        
    }

    public IPet GetPet(Guid id)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyCollection<IOwner> GetAllOwners()
    {
        throw new NotImplementedException();
    }

    public IOwner GetOwner(Guid id)
    {
        throw new NotImplementedException();
    }

    public IOwner RegisterNewOwner(IOwner owner)
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void RegisterNewPet_AddedSuccessfully()
    {
        ShelterService shelterService = new ShelterService();
        var pet = new Mock<Cat>();

        shelterService.RegisterNewPet(pet.Object);

        Assert.Equal(pet.Object, shelterService.GetPet(pet.Object.Id));
    }

    public IRequest RegisterNewRequest(IRequest request)
    {
        throw new NotImplementedException();
    }

    public bool ChangeOwnerToQualified(Guid id)
    {
        throw new NotImplementedException();
    }

    public void ChangeRequestStatus(Guid id, RequestStatus newStatus)
    {
        throw new NotImplementedException();
    }

    public void SatisfyRequest(Guid id)
    {
        throw new NotImplementedException();
    }
}