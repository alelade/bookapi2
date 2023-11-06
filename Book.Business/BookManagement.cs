namespace Book.Business;

using Shared.Framework;

public class BookManagement
{
    public BookManagement()
    {
        
    }

    public BusinessResult<bool> Create()
    {
        return BusinessResult<bool>.Ok(true);
    }
    public BusinessResult<IEnumerable<Book>> Get()
    {
        return BusinessResult<bool>.Ok(true);
    }
    public BusinessResult<bool> Create()
    {
        return BusinessResult<bool>.Ok(true);
    }
}