namespace GlobalExceptionHandling.ExceptionModels;

public class ConflictException : Exception
{
    public ConflictException(string message) : base(message)
    {

    }
}