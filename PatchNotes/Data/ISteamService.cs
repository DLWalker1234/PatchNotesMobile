using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatchNotes
{
    public interface ISteamService
    {
        Task<List<Game>> GetStringAsync();

        Task<Player> GetPlayer();
    }
}