namespace Core.Entities
{
    public class Service : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //public Currency Currency { get; set; }
        public string PictureUrl { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}