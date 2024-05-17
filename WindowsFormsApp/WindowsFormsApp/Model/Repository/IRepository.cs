using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Model.Repository
{
    public interface IRepository<T> where T : class
    {
        void Save(T item);
        T Get(int id);
        T[] GetAll();
        void Delete(int id); // удаление объекта по id
    }
}
