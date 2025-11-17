namespace Innoshop.Contracts.UserManagement;

public class UserDeactivatedMessage
{
    public const string QueueName = "UserManagement.User.Deactivated";

    public Guid UserId { get; init; }
    public DateTime DeactivatedAtUtc { get; init; }
}