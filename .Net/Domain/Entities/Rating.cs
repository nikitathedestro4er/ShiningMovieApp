namespace Domain.Entities
{
    public class Rating
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int CustomerId { get; set; }
        

        public double Rate { get; set; }
    }
}