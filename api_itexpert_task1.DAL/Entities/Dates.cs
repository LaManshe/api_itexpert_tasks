using api_itexpert_task1.DAL.Entities.Base;

namespace api_itexpert_task1.DAL.Entities
{
    public class Dates : Entity
    {
        public int IdOfDate { get; set; }
        public DateTime Date{ get; set; }
    }
}
