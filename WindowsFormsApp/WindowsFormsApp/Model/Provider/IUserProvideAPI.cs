using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model.Provider
{
    public interface IUserProvideAPI : IProviderAPI<User>
    {
        Task<User[]> UsersFromListAsync(IEnumerable<int> listId);
    }
}
