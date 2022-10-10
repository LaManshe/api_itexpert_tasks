using api_itexpert_task1.DAL.Entities;
using api_itexpert_task1.Interfaces;
using api_itexpert_task1.Models;
using api_itexpert_task1.Services.Interfaces;

namespace api_itexpert_task1.Services
{
    public class ClientDbManager : IClientDbManager
    {
        private readonly IRepository<ClientContacts> _repositoryContacts;
        private readonly IRepository<Client> _repositoryClient;

        public ClientDbManager(IRepository<ClientContacts> repositoryContacts, IRepository<Client> repositoryClient)
        {
            _repositoryContacts = repositoryContacts;
            _repositoryClient = repositoryClient;
        }
        public List<ClientCountContactsModel> GetClientCountContacts()
        {
            List<ClientCountContactsModel> result = new List<ClientCountContactsModel>();

            var contacts = _repositoryContacts.Items.ToList();
            foreach(var client in _repositoryClient.Items.ToList())
            {
                result.Add(new ClientCountContactsModel() { Name = client.Name, ContactCount = contacts.Where(x => x.Client.Id == client.Id).Count() });
            }

            return result;
        }

        public List<ClientWhoMoreThan> GetClientWhoMoreThan(int count)
        {
            List<ClientWhoMoreThan> result = new List<ClientWhoMoreThan>();
            var client_contacts = GetClientCountContacts();

            foreach(var client in client_contacts)
            {
                if (client.ContactCount > count)
                {
                    result.Add(new ClientWhoMoreThan() { Name = client.Name });
                }
            }

            return result;
        }
    }
}
