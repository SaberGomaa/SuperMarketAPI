namespace Entities.Exceptions
{
    public sealed class AdminNotFoundException : NotFoundException
    {
        public AdminNotFoundException(int id) : base($"The Admin with id: {id} doesn't exist in the database.")
        { }
    }
}
