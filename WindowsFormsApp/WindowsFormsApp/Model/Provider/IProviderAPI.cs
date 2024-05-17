using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model.Entities;

namespace WindowsFormsApp.Model.Provider
{
    public interface IProviderAPI<T> where T : IEntity
    {
        T[] GetAll(int page, int size);
        T GetOf(int id);
        void DeleteAll();
        void DeleteById(int id);
    }
}
