using PlatPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlatPet.Servicos
{
    public class ServicoDataStore : IDataStore<UsuarioPesssoa>
    {
        private static UsuarioPesssoa usuarioPesssoas = new UsuarioPesssoa();
            

        public void Add(UsuarioPesssoa usuarioPesssoa)
        {
            throw new NotImplementedException();
        }

        public void Delete(UsuarioPesssoa item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioPesssoa> GetAll()
        {
            throw new NotImplementedException();
        }

        public UsuarioPesssoa GetById(long? id)
        {
            throw new NotImplementedException();
        }

        public void Update(UsuarioPesssoa item)
        {
            throw new NotImplementedException();
        }
    };

}
