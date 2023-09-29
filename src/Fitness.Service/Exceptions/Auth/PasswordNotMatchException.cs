namespace Fitness.Service.Exceptions.Auth;

public class PasswordNotMatchException: BadRequestException
{
    public PasswordNotMatchException()
    {
        TitleMessage = "Parol yaroqsiz!";
    }
}
