namespace WindowsFormsApp.Model.Entities
{
    public class Profile : User
    {
        string password;

        public Profile(int id, string userName, string login, Role role) : base(id, userName, login, role)
        {
        }

        public string Password { get { return password; } set { password = value; } }
        public new int Id { get { return id; } set { id = value; } }
        public new string UserName { get { return userName; } set { userName = value; } }
        public new string Login { get { return login; } set { login = value; } }
        public new Role Role { get { return role; } set { role = value; } }
    }
}
