using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model.Provider
{
    public interface IProviderAPI<T> where T : IEntity
    {
        Task<T[]> GetAllAsync(int page, int size);
        Task<T> GetOfAsync(int id);
        void DeleteAllAsync();
        Task<HttpResponseMessage> DeleteByIdAsync(int id);
    }
}
