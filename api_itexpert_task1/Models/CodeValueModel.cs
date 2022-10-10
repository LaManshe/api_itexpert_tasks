using api_itexpert_task1.DAL.Entities.Base;

namespace api_itexpert_task1.Models
{
    public class CodeValueModel : Entity
    {
        public int Code { get; set; }
        public string Value { get; set; }
    }
}