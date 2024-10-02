namespace ContactsApi.Models.Interfaces
{
    public interface IUser
    {
        User RegisterUser(User user);
        User Authenticate(string username, string password);
        User GetUser(int idUser);
        void ChangePassword(User user, string oldPassword, string newPassword);
        void DeleteUser(int idUser);
    }
}
