namespace Domain.Exceptions
{
    public class CustomerNotFoundException : NotFoundException
    {
        public CustomerNotFoundException(string userId) : base($"The customer with the identifier {userId} was not found.")
        {
        }
        
        public CustomerNotFoundException(int Id) : base($"The customer with the identifier {Id} was not found.")
        {
        }
    }
}