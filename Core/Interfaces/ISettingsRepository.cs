using Core.Entities.Identity;

namespace Core.Interfaces
{
    public interface ISettingsRepository
    {

        #region Plan reporsitory
        Task<Plan> GetPlanByIdAsync(int id);
        Task<IReadOnlyList<Plan>> GetPlanAsync();
        #endregion
    }
}