namespace BuberDinner.Application.Services.Authentication;

public record AuthentificationResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);