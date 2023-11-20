using Core.Entities.Identity;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class SettingsRepository : ISettingsRepository
    {
        public Task<IReadOnlyList<Plan>> GetPlanAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Plan> GetPlanByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}