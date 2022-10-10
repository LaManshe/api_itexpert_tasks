using api_itexpert_task1.DAL.Entities;
using api_itexpert_task1.Interfaces;
using api_itexpert_task1.Models;
using api_itexpert_task1.Services.Interfaces;
using AutoMapper;

namespace api_itexpert_task1.Services
{
    public class DatesDbManager : IDateDbManager
    {
        private readonly IRepository<Dates> _repository;
        private readonly IMapper _mapper;

        public DatesDbManager(IRepository<Dates> repository)
        {
            _repository = repository;
        }
        public List<IdSdEdModel> ComputeDates()
        {
            List<IdSdEdModel> result = new List<IdSdEdModel>();
            List<Dates> correctedList = new List<Dates>();

            var dates = _repository.Items.ToList();

            var ids = dates.DistinctBy(x => x.IdOfDate).Select(item => item.IdOfDate).ToList();

            foreach (var id in ids)
            {
                if (dates.Where(item => item.IdOfDate == id).Count() < 2) continue;

                List<Dates> dates_of_ids = new List<Dates>();
                foreach (var date in dates.Where(item => item.IdOfDate == id))
                {
                    dates_of_ids.Add(date);
                }

                correctedList.AddRange(dates_of_ids.OrderBy(x => x.Date));
            }

            for(int i = 0; i < correctedList.Count - 1; i++)
            {
                if (correctedList[i].IdOfDate != correctedList[i + 1].IdOfDate) continue;

                result.Add(new IdSdEdModel() { Id = correctedList[i].IdOfDate, Sd = correctedList[i].Date, Ed = correctedList[i + 1].Date });
            }

            return result.OrderBy(x => x.Id).ToList();
        }
    }
}
