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
    public BusinessResult<bool> Update()
    {
        return BusinessResult<bool>.Ok(true);
    }
}