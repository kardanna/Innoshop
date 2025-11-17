namespace Innoshop.Contracts.UserManagement;

public class UserReactivatedMessage
{
    public const string QueueName = "UserManagement.User.Reactivated";

    public Guid UserId { get; init; }
    public DateTime ReactivatedAtUtc { get; init; }
}