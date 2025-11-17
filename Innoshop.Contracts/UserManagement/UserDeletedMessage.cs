namespace Innoshop.Contracts.UserManagement;

public class UserDeletedMessage
{
    public const string QueueName = "UserManagement.User.Deleted";

    public Guid UserId { get; init; }
    public DateTime DeletedAtUtc { get; init; }
}