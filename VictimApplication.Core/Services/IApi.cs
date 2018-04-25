using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using VictimApplication.Core.Models;

namespace VictimApplication.Core.Services
{
    public interface IApi
    {

        [Get("/api/user/getuser/1")]
        Task<String> GetDefaultUser();

        [Post("/api/user/createuser")]
        Task CreateUser([Body(BodySerializationMethod.Json)] UserForCreationDto user);

        [Post("/api/user/login")]
        Task<LoggedUserDto> Login([Body(BodySerializationMethod.Json)] UserToLoginDto user);

        [Get("/api/case/getListOfCasesForUser")]
        //Task<LoggedUserDto> GetListOfCasesForUser([Body(BodySerializationMethod.Json)] UserToLoginDto user);
        Task<List<CaseDto>> GetListOfCasesForUser([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);
    }
}
