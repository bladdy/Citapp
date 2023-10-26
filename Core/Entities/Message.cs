namespace Core.Entities.Identity
{
    public class Message: BaseEntity
    {
        public string Content { get; set; }
        public DateTime SentDate { get; set; }
        /*public AppUser Sender { get; set; }
        public AppUser Addressee { get; set; }*/
        public bool Read { get; set; }
                        
    }
}