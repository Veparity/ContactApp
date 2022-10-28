using ContactApp.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace ContactApp.Services.Interfaces
{
    public interface IAddressBookService
    {
        //create a method

        public Task AddContactToCategoryAysnc(int categoryId, int contactId);

        public Task AddContactToCategoriesAsync(IEnumerable<int> categoryIds, int contactId);
        public Task<bool> IsContactInCategory(int categoryId, int contactId);

        public Task<IEnumerable<Category>> GetAppUserCategoriesAsync(string appUserId);

        public Task RemoveAllContactCategoriesAysnc(int contactId);

    }
}
