using System;
using System.Threading.Tasks;
using Refit;
using VictimApplication.Core.Models;

namespace VictimApplication.Core.Services
{
    public interface IApi
    {
        [Get("/api/deck/new/shuffle/?deck_count=1")]
        Task<String> GetSample();

        [Get("/api/user/getuser/1")]
        Task<String> GetDefaultUser();

        [Post("/api/user/createuser")]
        Task CreateUser([Body(BodySerializationMethod.Json)] UserForCreationDto user);

        [Post("/api/user/login")]
        Task<LoggedUserDto> Login([Body(BodySerializationMethod.Json)] UserToLoginDto user);

    }
}
