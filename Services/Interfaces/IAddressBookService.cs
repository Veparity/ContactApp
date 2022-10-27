namespace ContactApp.Services.Interfaces
{
    public interface IAddressBookService
    {
        //create a method

        public Task AddContactToCategoryAysnc(int categoryId, int contactId);
        Task<bool> IsContactInCategory(int categoryId, int contactId);
    }
}
