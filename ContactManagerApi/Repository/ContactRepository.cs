using ContactManagerApi.Data;
using ContactManagerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerApi.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDBContext context;

        public ContactRepository(ContactDBContext context)
        {
            this.context = context;
        }

        public async Task<Contact> AddContactAsync(Contact contact)
        {

            await context.Contacts.AddAsync(contact);
            await context.SaveChangesAsync();

            return contact;
        }

        public async Task<Contact> DeleteContactAsync(int id)
        {
         var existingContact =   await  context.Contacts.FirstOrDefaultAsync(c => c.Id == id);

            if(existingContact == null)
            {
                return null;
            }

            context.Contacts.Remove(existingContact);
            await context.SaveChangesAsync();
            return existingContact;

        }

        public async Task<List<Contact>> GetAllContactsAsync()
        {
          List<Contact> contacts =  await context.Contacts.ToListAsync();

            if (contacts == null)
            {
                return null;
            }

            return contacts;
        }

        public async Task<Contact> GetContactAsync(int id)
        {
            var existingContact =  await context.Contacts.FirstOrDefaultAsync(c => c.Id == id);
            if (existingContact == null)
            {
                return null;
            }
            return existingContact;
        }

        public async Task<Contact> UpdateContactAsync(int id,Contact contact)
        {

            var existingContact = await context.Contacts.FirstOrDefaultAsync(c => c.Id == id);
            if (existingContact == null)
            {
                return null;
            }

            existingContact.Name = contact.Name;
            existingContact.Phone = contact.Phone;
            existingContact.Email = contact.Email;
            existingContact.Address = contact.Address;
            existingContact.City = contact.City;
            existingContact.State = contact.State;
            existingContact.PostalCode = contact.PostalCode;

            await context.SaveChangesAsync();

            return existingContact;

        }
    }
}
