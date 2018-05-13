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

        [Get("/api/case/getlistofcasesforuser/{userId}")]
        //Task<IEnumerable<CaseDto>> GetListOfCasesForUser([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);
        Task<IEnumerable<CaseDto>> GetListOfCasesForUser([AliasAs("userId")]int userId);

        [Get("/api/message/getMessagesForCase/{caseId}")]
        Task<IEnumerable<MessageDto>> GetListOfMessagesForCase([AliasAs("caseId")]int caseId);

        [Post("/api/message/sendmessage")]
        Task SendMessage([Body(BodySerializationMethod.Json)] MessageForCreationDto message);

        [Put("/api/case/updatecase")]
        Task UpdateCase([Body(BodySerializationMethod.Json)] CaseDto casetoget);

        [Get("/api/case/getcasebyid/{caseId}")]
        Task<CaseDto> GetCaseById([AliasAs("caseId")] int caseId);

		[Post("/api/case/createCase")]
		Task CreateCase([Body(BodySerializationMethod.Json)] CaseForCreationDto caseForCreation);

    }
}
