using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Model.Provider
{
    internal class UserProviderAPI : IUserProvideAPI
    {
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public User[] GetAll(int page, int size)
        {
            throw new NotImplementedException();
        }

        public User GetOf(int id)
        {
            throw new NotImplementedException();
        }

        public User[] UsersFromList(IEnumerable<int> listId)
        {
            throw new NotImplementedException();
        }
    }
}
