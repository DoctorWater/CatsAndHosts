namespace CatsAndHosts.Exceptions.NotFound;

public class PetNotFoundException : Exception
{
    public PetNotFoundException(Guid id) : base("Pet with this id was not found: " + id)
    {
    }
}