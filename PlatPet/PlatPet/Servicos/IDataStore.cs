using System;
using System.Collections.Generic;
using System.Text;

namespace PlatPet.Servicos
{
    public interface IDataStore<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        T GetById(long? id);
        IEnumerable<T> GetAll();

    }
}
