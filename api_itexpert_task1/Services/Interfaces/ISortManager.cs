using api_itexpert_task1.Models;

namespace api_itexpert_task1.Services.Interfaces
{
    public interface ISortManager
    {
        List<CodeValueModel> Sort(List<CodeValueModel> items);
    }
}
