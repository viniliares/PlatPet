using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using PlatPet.Models;

namespace PlatPet.Servicos.UsuarioPessoa
{
    public class UsuarioPessoaService : IUsuarioPessoaService
    {
        private readonly IRequest _request;
        private const string ApiUrlBase = "http://universesoftware2019.somee.com/api/CadUsuarios";

        public UsuarioPessoaService()
        {
            _request = new Request();
        }

        public async Task<UsuarioPesssoa> DeleteUsuarioPessoaAsync(int usuarioId)
        {
            string urlComplementar = string.Format("/{0}", usuarioId);
            await _request.DeleteAsync(ApiUrlBase + urlComplementar);
            return new UsuarioPesssoa() { IdUsuario = usuarioId };
        }

        public async Task<ObservableCollection<UsuarioPesssoa>> GetUsuarioPessoaAsync()
        {
            ObservableCollection<Models.UsuarioPesssoa> usuarioPesssoa = await
                _request.GetAsync<ObservableCollection<Models.UsuarioPesssoa>>(ApiUrlBase);

            return usuarioPesssoa;
        }

        public async Task<UsuarioPesssoa> PostUsuarioPessoaAsync(UsuarioPesssoa c)
        {
            if (c.IdUsuario == 0)
            {
                string urlComplementar = string.Format("/I/{0}", c.TipoUsuario);
                return await _request.PostAsync(ApiUrlBase, c);
            }
            else
                return await _request.PutAsync(ApiUrlBase, c);
        }

        public async Task<UsuarioPesssoa> PutUsuarioPessoaAsync(UsuarioPesssoa c)
        {
            string urlComplementar = string.Format("/U/{0}", c.IdUsuario);
            var result = await _request.PutAsync(ApiUrlBase, c);
            return result;
        }
    }
}
