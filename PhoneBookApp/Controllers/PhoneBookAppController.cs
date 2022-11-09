using PhoneBookApp.Data;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Controllers
{
    public class PhoneBookAppController
    {
        public void CreateContact()
        {
            GetInput getInput = new GetInput();

            var context = new PhoneBookAppDbContext();

            var newContact = new Contact();

            Console.WriteLine("New Contact");

            Console.WriteLine("\nCentact Name:");
            string contactName = Console.ReadLine();
            Console.WriteLine("\nPhone Number:");
            string contactNumber = Console.ReadLine();

            newContact.Name = contactName;
            newContact.PhoneNumber = contactNumber;            

            context.Contacts.Add(newContact);
            context.SaveChanges();

            Console.WriteLine("\nContact Created.\nPress Enter...");
            Console.ReadLine();

            getInput.MainMenu();
        }

        public void DeleteContact()
        {
            GetInput getInput = new GetInput();
            DisplayTable displayTable = new DisplayTable();

            displayTable.DisplayContacts();

            var context = new PhoneBookAppDbContext();            

            Console.WriteLine("Delete Contact");

            Console.WriteLine("\nId of contact to Delete:");
            string contactId = Console.ReadLine();
            int id = Int32.Parse(contactId);

            var deleteContact = context.Contacts.Find(id);

            context.Contacts.Remove(deleteContact);
            context.SaveChanges();

            Console.WriteLine("\nContact Deleted.\nPress Enter...");
            Console.ReadLine();

            getInput.MainMenu();
        }
    }
}
