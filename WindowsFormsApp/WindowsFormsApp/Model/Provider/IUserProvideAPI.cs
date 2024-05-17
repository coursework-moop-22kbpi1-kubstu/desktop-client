using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Model.Provider
{
    public interface IUserProvideAPI : IProviderAPI<User>
    {
        User[] UsersFromList(IEnumerable<int> listId);
    }
}
