using PhoneBookApp.Data;
using PhoneBookApp.Data.Dto;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class DisplayTable
    {
        public void DisplayContacts()
        {
            var context = new PhoneBookAppDbContext();

            List<Contact> contacts = new List<Contact>();

            foreach (var contact in context.Contacts)
            {
                contacts.Add(contact);                
            }

            FormatTable.ShowContacts(contacts);
        }

        public void DisplayContactsList()
        {
            var context = new PhoneBookAppDbContext();

            List<Contact> contacts = new List<Contact>();

            foreach (var contact in context.Contacts)
            {
                contacts.Add(contact);
            }

            List<ContactReadOnlyDto> contactsForDisplay = new();

            int contactNumber = 1;

            foreach (var contact in contacts)
            {
                contactsForDisplay.Add(new ContactReadOnlyDto() { Number = contactNumber, Name = contact.Name, PhoneNumber = contact.PhoneNumber });                
                contactNumber++;
            }

            FormatTable.ShowContacts(contactsForDisplay);
        }
    }
}
