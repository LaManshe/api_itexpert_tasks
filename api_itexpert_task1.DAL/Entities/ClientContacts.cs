using api_itexpert_task1.DAL.Entities.Base;

namespace api_itexpert_task1.DAL.Entities
{
    public class ClientContacts : Entity
    {
        public Client Client { get; set; }
        public string ContactType { get; set; }
        public string ContactValue { get; set; }
    }
}
