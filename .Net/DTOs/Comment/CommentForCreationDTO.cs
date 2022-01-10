namespace DTOs.Comment
{
    public class CommentForCreationDTO
    {

        public string UserName { get; set; }
        
        public int CustomerId { get; set; }

        public int MovieId { get; set; }

        public string Content { get; set; }
        
    }
}