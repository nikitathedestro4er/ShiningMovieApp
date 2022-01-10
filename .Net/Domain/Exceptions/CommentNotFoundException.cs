namespace Domain.Exceptions
{
    public sealed class CommentNotFoundException : NotFoundException
    {
        public CommentNotFoundException(int commentId) : base($"The comment with the identifier {commentId} was not found.")
        {
        }
    }
}