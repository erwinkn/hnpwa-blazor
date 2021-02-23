using System.Collections.Generic;
using System.Threading.Tasks;
using HnpwaBlazor.Shared.Models;

namespace HnpwaBlazor.Shared.Services
{
    public interface IApiService
    {
        Task<List<Item>> GetList(string category, int pageNb=1);
        Task<Item> GetItem(int id);
        Task<List<IPollOption>> GetPollOptions(int pollId, int nbOptions);
    }
}