using ContactManagerApi.Models;

namespace ContactManagerApi.Repository
{
    public interface IContactRepository
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task<Contact> GetContactAsync(string telephone);
        Task<List<Contact>> GetAllContactsAsync();
        Task<Contact> UpdateContactAsync(string telephone,Contact contact);
        Task<Contact> DeleteContactAsync(string telephone);
        
    }
}
