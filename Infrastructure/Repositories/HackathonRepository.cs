using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories
{
    public class HackathonRepository : IHackathonRepository
    {
        public async Task<Hackathon> CreateHackathon(Hackathon hackathon)
        {
            throw new System.NotImplementedException();
        }
    }
}