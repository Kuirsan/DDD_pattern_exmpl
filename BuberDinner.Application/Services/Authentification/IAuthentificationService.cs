namespace BuberDinner.Application.Services.Authentication;

public interface IAuthentificationService
{
    AuthentificationResult Login(string email, string password);
    AuthentificationResult Register(string firstName, string lastName, string email, string password);
}