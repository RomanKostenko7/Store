namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByIds(IEnumerable<int> bookIds);
        Book[] GetAllByIsbn(string isbn);
        Book[] GetAllByTitleOrAuthor(string titlePartOrAuthor);
        Book GetById(int id);
    }
}
