namespace CatsAndHosts.Exceptions.NotFound;

public class RequestNotFoundException : Exception
{
    public RequestNotFoundException(Guid id) : base("Request with this id was not found: " + id)
    {
    }
}