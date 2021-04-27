using System.Collections.Generic;
using LibraryManagement.Model;
namespace LibraryManagement.Services
{
    public interface IBookBorrowingRequestService : IHandler<BookBorrowingRequest>
    {
        bool CreateRequest(int userId , List<int> bookIds);
     
    }
}