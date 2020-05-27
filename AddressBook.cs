using System.Collections.Generic;

namespace address_book
{
    public class AddressBook
    {
        public Dictionary<Contact, string> addresses = new Dictionary<Contact, string>();

        public void AddContact(Contact contact, string emailAddress)
        {
            addresses.Add(contact, emailAddress);
        }
    }
}