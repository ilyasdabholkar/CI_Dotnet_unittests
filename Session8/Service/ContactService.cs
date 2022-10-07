using Session8.Interfaces;
using Session8.Models;

namespace Session8.Service
{
    public class ContactService : IContactService
    {
        private List<Contact> _contacts;

        public ContactService()
        {
            _contacts = new List<Contact>()
            {
                new Contact(){ 
                    ContactId =new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Name = "Ilyas Dabholkar",
                    MobileNo = "918806366787"
                },
                new Contact(){
                    ContactId =new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
                    Name = "Mitesh Kadu",
                    MobileNo = "918806366787"
                },
                new Contact(){
                    ContactId =new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
                    Name = "Shreya Thale",
                    MobileNo = "918806366787"
                }
            };
        }

        //Get All Contacts
        public List<Contact> GetAllContacts()
        {
            return _contacts;
        }

        //Get Contact By Id
        public Contact GetContact(Guid id)
        {
            return _contacts.FirstOrDefault(c => c.ContactId == id);
        }
    }
}
