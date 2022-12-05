using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    internal class Phonebook //responsible for managing contact list
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact) => _contacts.Add(contact);
               // create a internal database to store contacts using list

        public void ShowContactDetails(Contact contact)
            => Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");

        public void DisplayContactByNumber(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
                                      //search contact on contact list
            if (contact == null) //to avoid null reference exception
                Console.WriteLine("Contact not found");
            else
                ShowContactDetails(contact);
        }

        private void DisplaySearchedContact(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                ShowContactDetails(contact);
            }
        }

        public void DisplayContactByName(string searchPhrase)
                    // will display contacts that contain input letters
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();

            if (matchingContacts == null)
                Console.WriteLine("Contact not found");
            else
                DisplaySearchedContact(matchingContacts);
        }

        public void DisplayAllContacts() => DisplaySearchedContact(_contacts);
    }
}