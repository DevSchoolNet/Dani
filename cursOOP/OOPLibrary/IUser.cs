namespace OOPLibrary {
    public interface IUser {
        string Name { get; }
        string Password { get; }
        string Email { get; set; }
        void Login(string name, string password);
        void Logout();
    }
}