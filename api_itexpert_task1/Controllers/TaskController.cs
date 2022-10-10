using api_itexpert_task1.Data;
using api_itexpert_task1.Models;
using api_itexpert_task1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_itexpert_task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ISortManager _sortManager;
        private readonly IDbManager _dbManager;
        public TaskController(
            ISortManager sortManager,
            IDbManager dbManager)
        {
            _sortManager = sortManager;
            _dbManager = dbManager;
        }

        [HttpGet]
        [Route("")]
        public List<CodeValueModel> Get()
        {
            return _dbManager.GetValues();
        }

        [HttpGet]
        [Route("ByDescending")]
        public List<CodeValueModel> GetFilteredByDescending()
        {
            return _dbManager.GetValues().OrderByDescending(x => x.Code).ToList();
        }

        [HttpGet]
        [Route("ByAscending")]
        public List<CodeValueModel> GetFilteredByAscending()
        {
            return _dbManager.GetValues().OrderBy(x => x.Code).ToList();
        }

        // POST api/<TaskController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            List<CodeValueModel> listValues = new List<CodeValueModel>();
            foreach(var item in MyDeserializer.GetPairOfCodeValueModel(value))
            {
                listValues.Add(item);
            }

            string result = _dbManager.InsertNewValues(_sortManager.Sort(listValues).ToArray());

            return Ok(result);
        }
    }
}
