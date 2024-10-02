namespace ContactsApi.Models.Interfaces
{
    public interface IContact
    {
        Contact AddContact(Contact contact);
        Contact GetContact(int idContact);
        Contact UpdateContact(int idContact,Contact contact);
        List<Contact> SearchContacts(int idUser, string term);
        List<Contact> GetAllContacts(int idUser);
        void DeleteContact(int idContact);
        void UpdateFavorite(int idContact);

    }
}
