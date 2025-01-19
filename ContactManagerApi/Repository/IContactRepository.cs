using ContactManagerApi.Models;

namespace ContactManagerApi.Repository
{
    public interface IContactRepository
    {
        Task<Contact> AddContactAsync(Contact contact);
        Task<Contact> GetContactAsync(int id);
        Task<List<Contact>> GetAllContactsAsync();
        Task<Contact> UpdateContactAsync(int id,Contact contact);
        Task<Contact> DeleteContactAsync(int id);
        
    }
}
