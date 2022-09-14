using BuberDinner.Application.Common.Interfaces.Authentification;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthentificationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthentificationResult Login(string email, string password)
    {
        return new AuthentificationResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token");
    }

    public AuthentificationResult Register(string firstName, string lastName, string email, string password)
    {
        //Check if user already exist

        //Create user

        //create token
        Guid userId = Guid.NewGuid();

        var token = _jwtTokenGenerator.GenerateToken(userId,firstName,lastName);

        return new AuthentificationResult(
            userId,
            firstName,
            lastName,
            email,
            token);
    }
}