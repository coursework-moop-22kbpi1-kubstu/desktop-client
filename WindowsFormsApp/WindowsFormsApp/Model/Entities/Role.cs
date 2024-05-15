namespace WindowsFormsApp.Model.Entities
{
    public class Role
    {
        public enum NameRole
        {
            User,
            Employee,
            Admin
        }
        private NameRole name;
        public Role(NameRole nameRole)
        {
            name = nameRole;
        }
        public Role(string nameRole)
        {
            switch (nameRole)
            {
                case "User":
                    {
                        name = NameRole.User;
                        break;
                    }
                case "Employee":
                    {
                        name = NameRole.Employee;
                        break;
                    }
                case "Admin":
                    {
                        name = NameRole.Admin;
                        break;
                    }
                default:
                    {
                        throw new Exception("Неверное значение для Role -'" + nameRole + "'.");
                    }
            }
        }
        public string Name
        {
            get
            {
                return name.ToString();
            }
        }
    }
}
