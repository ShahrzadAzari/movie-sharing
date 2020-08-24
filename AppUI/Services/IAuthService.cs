using System.Threading.Tasks;
using SharedData;

namespace Services
{
    public interface IAuthService
    {
            Task<LoginResult> Login(LoginModel loginModel);
            Task Logout();
            Task<RegisterResult> Register(RegisterModel registerModel);
    }
}