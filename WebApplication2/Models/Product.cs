using WebApplication2.Models.Category;

namespace WebApplication2.Models
{
    public class Productt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public Categoryy Category { get; set; }
    }
}
