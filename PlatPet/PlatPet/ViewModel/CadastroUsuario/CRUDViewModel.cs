using PlatPet.Servicos;
using System;
using System.Collections.Generic;
using System.Text;
using PlatPet.Models;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using PlatPet.Servicos.UsuarioPessoa;

namespace PlatPet.ViewModel.CadastroUsuario
{
    public class CRUDViewModel : BaseViewModel
    {
        //private IDataStore<UsuarioPesssoa> DataStore = new ServicoDataStore();
        private IUsuarioPessoaService cService = new UsuarioPessoaService();
        private UsuarioPesssoa UsuarioPessoa { get; set; }
        public ICommand GravarCommand { get; set; }

        private ObservableCollection<UsuarioPesssoa> UsuarioPessoas;

        public CRUDViewModel(UsuarioPesssoa usuarioPesssoa, ObservableCollection<UsuarioPesssoa> usuarioPesssoas)
        {
            this.UsuarioPessoa = usuarioPesssoa;
            RegistrarCommands();
            this.UsuarioPessoa = usuarioPesssoa;
        }

        private void RegistrarCommands()
        {
            GravarCommand = new Command(async() =>
            {
                Gravar();
                MessagingCenter.Send<string>("Atualização realizada com sucesso.", "InformacaoCRUD");
            });
        }

        public void Gravar()
        {
            var ehNovo = (this.UsuarioPessoa.IdUsuario == null ? true : false);
            //DataStore.Update(this.UsuarioPessoa);
            
        }

        public string Usuario
        {
            get { return this.UsuarioPessoa.UserUsuario; }
            set
            {
                this.UsuarioPessoa.UserUsuario = value;
                OnPropertyChanged();
                ((Command)GravarCommand).ChangeCanExecute();
            }
        }

        public string Nome
        {
            get { return this.UsuarioPessoa.NomePessoa; }
            set
            {
                //Atribuirá valor a propriedade
                this.UsuarioPessoa.NomePessoa = value;

                //Atuálizará a propriedade ligada a view
                //Método presente na classe herdada
                OnPropertyChanged();
            }
        }

        public string Sobrenome
        {
            get { return this.UsuarioPessoa.SobrenomePessoa; }
            set
            {
                this.UsuarioPessoa.SobrenomePessoa = value;
                OnPropertyChanged();
            }
        }

        public string Senha
        {
            get { return this.UsuarioPessoa.PassUsuario; }
            set
            {
                this.UsuarioPessoa.PassUsuario = value;
                OnPropertyChanged();
            }
        }

        public string CPF
        {
            get { return this.UsuarioPessoa.CPFPessoa; }
            set
            {
                this.UsuarioPessoa.CPFPessoa = value;
                OnPropertyChanged();
            }
        }

        public string Telefone
        {
            get { return this.UsuarioPessoa.TelefonePessoa; }
            set
            {
                this.UsuarioPessoa.TelefonePessoa = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return this.UsuarioPessoa.EmailPessoa; }
            set
            {
                this.UsuarioPessoa.EmailPessoa = value;
                OnPropertyChanged();
            }
        }

        public string Endereco
        {
            get { return this.UsuarioPessoa.EnderecoPessoa; }
            set
            {
                this.UsuarioPessoa.EnderecoPessoa = value;
                OnPropertyChanged();
            }
        }
    }
}
