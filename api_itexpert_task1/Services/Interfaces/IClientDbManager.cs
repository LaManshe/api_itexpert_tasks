using api_itexpert_task1.Models;

namespace api_itexpert_task1.Services.Interfaces
{
    public interface IClientDbManager
    {
        List<ClientCountContactsModel> GetClientCountContacts();
        List<ClientWhoMoreThan> GetClientWhoMoreThan(int count);
    }
}
