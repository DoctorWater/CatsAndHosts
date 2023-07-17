namespace CatsAndHosts.Exceptions;

public class WrongRequestStatusException : Exception
{
    public WrongRequestStatusException(RequestStatus currentStatus, RequestStatus requiredStatus) : base(
        "Request has wrong status: " + currentStatus + " instead of " + requiredStatus)
    {
    }
}