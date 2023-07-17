namespace CatsAndHosts.Exceptions.NotFound;

public class OwnerNotFoundException : Exception
{
    public OwnerNotFoundException(Guid id) : base("Owner with this id was not found: " + id)
    {
    }
}