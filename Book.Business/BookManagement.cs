namespace Book.Business;

using Data;
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
    public BusinessResult<IEnumerable<global::Book>> Get()
    {
        return BusinessResult<IEnumerable<global::Book>>.Ok(new List<Book>());
    }
    public BusinessResult<bool> Update()
    {
        return BusinessResult<bool>.Ok(true);
    }
}