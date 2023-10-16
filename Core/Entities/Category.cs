namespace Core.Entities
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        
        public string IconUrl { get; set; }
        /*public string ImageFullPath => string.IsNullOrEmpty(IconUrl)
            ? $"https://localhost:5001/icons/no_image.png"
            : $"https://localhost:5001/{IconUrl}";*/
    }
}