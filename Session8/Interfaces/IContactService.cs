using Session8.Models;

namespace Session8.Interfaces
{
    public interface IContactService
    {
        public List<Contact> GetAllContacts();
        public Contact GetContact(Guid id);
    }
}
