using api_itexpert_task1.Models;
using api_itexpert_task1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_itexpert_task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientDbManager _dbManager;

        public ClientsController(IClientDbManager dbManager)
        {
            _dbManager = dbManager;
        }

        [HttpGet]
        [Route("GetClientNameAndCountContacts")]
        public List<ClientCountContactsModel> Get()
        {
            return _dbManager.GetClientCountContacts();
        }

        [HttpGet]
        [Route("GetClientNameMoreThan")]
        public List<ClientWhoMoreThan> Get(int count = 2)
        {
            return _dbManager.GetClientWhoMoreThan(count);
        }
    }
}
