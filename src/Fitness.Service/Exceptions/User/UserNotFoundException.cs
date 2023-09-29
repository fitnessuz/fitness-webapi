
namespace Fitness.Service.Exceptions.User;

public class UserNotFoundException : NotFoundException
{
    public UserNotFoundException()
    {
        this.TitleMessage = "User not found!";
    }
}
