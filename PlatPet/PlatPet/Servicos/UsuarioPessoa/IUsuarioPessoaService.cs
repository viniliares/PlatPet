using PlatPet.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;



namespace PlatPet.Servicos.UsuarioPessoa
{
    public interface IUsuarioPessoaService
    {
        Task<ObservableCollection<UsuarioPesssoa>> GetUsuarioPessoaAsync();

        Task<UsuarioPesssoa> PostUsuarioPessoaAsync(UsuarioPesssoa c);

        Task<UsuarioPesssoa> PutUsuarioPessoaAsync(UsuarioPesssoa c);

        Task<UsuarioPesssoa> DeleteUsuarioPessoaAsync(int pessoaId);
    }
}
