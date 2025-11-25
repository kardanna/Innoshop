namespace Innoshop.Contracts.UserManagement.UserEvents;

public class UserEventMessage
{
    public Guid UserId { get; init; }
    public DateTime TimeStamp { get; init; }
}