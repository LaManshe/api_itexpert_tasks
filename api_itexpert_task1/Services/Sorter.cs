using api_itexpert_task1.Models;
using api_itexpert_task1.Services.Interfaces;

namespace api_itexpert_task1.Services
{
    public class Sorter : ISortManager
    {
        public List<CodeValueModel> Sort(List<CodeValueModel> items)
        {
            List<CodeValueModel> sortedItems = items.OrderBy(x => x.Code).ToList();
            return sortedItems;
        }
    }
}
