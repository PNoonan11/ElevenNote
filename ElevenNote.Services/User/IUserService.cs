using ElevenNote.Models.User;
using System.Threading.Tasks;

namespace ElevenNote.Services.User
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(UserRegister model);
    }
}