using PhoneBookApp.Data.Dto;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Controllers
{
    public static class DtoController
    {
        public static ContactDto ToContactDto(this Contact contact)
        {
            if (contact == null)
            {
                return null;
            }

            var readContact = new ContactDto()
            {
                Id = contact.Id,
                Name = contact.Name,
                PhoneNumber = contact.PhoneNumber
            };

            return readContact;
        }

        public static Contact ToContact(this ContactDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            var readContact = new Contact()
            {
                Id=dto.Id,
                Name = dto.Name,
                PhoneNumber = dto.PhoneNumber
            };

            return readContact;
        }

    }
}
