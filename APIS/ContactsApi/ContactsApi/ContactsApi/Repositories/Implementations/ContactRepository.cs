using ContactsApi.Models;
using ContactsApi.Models.Interfaces;
using ContactsApi.Repositories.Database;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Repositories.Implementations
{
    public class ContactRepository : IContact
    {
        private readonly AppDbContext _context;
        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }
        public Contact AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            contact.User = null;
            return contact;
        }

        public void DeleteContact(int idContact)
        {
            var contact = _context.Contacts.FirstOrDefault(c => c.IdContact == idContact);
            if (contact == null)
            {
                throw new KeyNotFoundException("Contact not found");
            }
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
        }

        public List<Contact> GetAllContacts(int idUser)
        {
            List<Contact> contacts = _context.Contacts.Where(c => c.IdUser == idUser).ToList();
            return contacts;
        }

        public Contact GetContact(int idContact)
        {
            var contact = _context.Contacts.FirstOrDefault(c => c.IdContact == idContact) ?? throw new KeyNotFoundException("Contact not found");

            return contact;
        }

        public List<Contact> SearchContacts(int idUser, string term)
        {
            term = term.ToLowerInvariant();

            List<Contact> contacts = _context.Contacts.Where(c => c.IdUser == idUser && (c.Name.ToLower().Contains(term) || c.Lastname.ToLower().Contains(term))).ToList();
            return contacts;
        }

        public Contact UpdateContact(int idContact, Contact contact)
        {
            var updateContact = _context.Contacts.FirstOrDefault(c => c.IdContact == idContact) ?? throw new KeyNotFoundException("Contact not found");
            updateContact.Name = contact.Name;
            updateContact.Lastname = contact.Lastname;
            updateContact.Email = contact.Email;
            updateContact.PhoneNumber = contact.PhoneNumber;
            updateContact.MobileNumber = contact.MobileNumber;
            updateContact.Address = contact.Address;
            updateContact.City = contact.City;
            updateContact.Country = contact.Country;
            updateContact.Company = contact.Company;
            updateContact.JobTitle = contact.JobTitle;
            updateContact.DateOfBirth = contact.DateOfBirth;
            updateContact.Notes = contact.Notes;
            updateContact.ModificationDate = DateTime.Now;
            _context.SaveChanges();
            return updateContact;
        }
        public void UpdateFavorite(int idContact)
        {
            var updateContact = _context.Contacts.FirstOrDefault(c => c.IdContact == idContact) ?? throw new KeyNotFoundException("Contact not found");
            updateContact.IsFavorite = !updateContact.IsFavorite;
            _context.SaveChanges();
        }
    }
}
