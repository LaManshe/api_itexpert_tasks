using api_itexpert_task1.Models;

namespace api_itexpert_task1.Services.Interfaces
{
    public interface IDateDbManager
    {
        List<IdSdEdModel> ComputeDates();
    }
}
