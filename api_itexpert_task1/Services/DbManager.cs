using api_itexpert_task1.DAL.Entities;
using api_itexpert_task1.Interfaces;
using api_itexpert_task1.Models;
using api_itexpert_task1.Services.Interfaces;
using AutoMapper;

namespace api_itexpert_task1.Services
{
    public class DbManager : IDbManager
    {
        private readonly IRepository<CV> _repository;
        private readonly IMapper _mapper;

        public DbManager(IRepository<CV> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public string InsertNewValues(params CodeValueModel[] items)
        {
            _repository.Clear();

            foreach (var item in items)
            {
                var cv_item = _mapper.Map<CV>(item);
                _repository.Add(cv_item);
            }

            return "Ok";
        }
        public List<CodeValueModel> GetValues()
        {
            List<CodeValueModel> result = new List<CodeValueModel>();

            foreach(var item in _repository.Items)
            {
                result.Add(_mapper.Map<CodeValueModel>(item));
            }

            return result;
        }
    }
}
