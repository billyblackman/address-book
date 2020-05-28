using System.Collections.Generic;

namespace address_book
{
    public class AddressBook
    {
        public Dictionary<string, Contact> addresses = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            addresses[contact.Email] = contact;
        }

        public Contact GetByEmail(string email)
        {
            foreach(KeyValuePair <string, Contact> kvp in addresses)
            {
                if (kvp.Key == email)
                {
                    return kvp.Value;
                }
            }
            return null;            
        }
    }
}