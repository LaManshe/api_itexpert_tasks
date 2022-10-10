using api_itexpert_task1.Interfaces;
using api_itexpert_task1.Models;

namespace api_itexpert_task1.Services.Interfaces
{
    public interface IDbManager
    {
        string InsertNewValues(params CodeValueModel[] items);
        List<CodeValueModel> GetValues();
    }
}
