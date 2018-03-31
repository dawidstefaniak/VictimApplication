using System;
using System.Threading.Tasks;
using Refit;

namespace VictimApplication.Core.Services
{
    public interface IApi
    {
        [Get("/api/deck/new/shuffle/?deck_count=1")]
        Task<String> GetSample();
    }
}
