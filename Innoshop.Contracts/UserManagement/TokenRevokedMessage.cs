namespace Innoshop.Contracts.UserManagement;

public class TokenRevokedMessage
{
    public const string QueueName = "UserManagement.Token.Revoked";

    public Guid TokenId { get; init; }
    public DateTime TokenExpiresAtUtc { get; init; }
}