using api_itexpert_task1.Models;
using api_itexpert_task1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_itexpert_task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        private readonly IDateDbManager _dateManager;

        public DatesController(IDateDbManager dateManager)
        {
            _dateManager = dateManager;
        }

        [HttpGet]
        public List<IdSdEdModel> Get()
        {
            return _dateManager.ComputeDates();


        }
    }
}
