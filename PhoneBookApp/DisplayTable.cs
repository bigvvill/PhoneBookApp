using PhoneBookApp.Controllers;
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

            List<ContactDto> contactsDto = new List<ContactDto>();
            int listNumber = 1;
            foreach (var contact in contacts)
            {
                DtoController.ToContactDto(contact);

                contactsDto.Add(new ContactDto
                {
                    Id = listNumber,
                    Name = contact.Name,
                    PhoneNumber = contact.PhoneNumber
                });

                listNumber++;
            }



            FormatTable.ShowContacts(contacts);
        }        
    }
}
